using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Setu.API.Models;
using Setu.API.PaymenGatewayHelper.Cashfree;
using Setu.Common;
using Setu.Common.DTO;
using Setu.Common.MailHelper;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SalaryController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        CashFreeGateway cashFreeGateway { get; set; }
        UserContext userContext { get; set; }
        IConfiguration configuration { get; set; }
        private IMailService mailService { get; set; }
        public SalaryController(CashFreeGateway cashFreeGateway, StaffContext staffContext, IConfiguration configuration,
            IMailService mailService, UserContext userContext)
        {
            this.staffContext = staffContext;
            this.cashFreeGateway = cashFreeGateway;
            this.configuration = configuration;
            this.mailService = mailService;
            this.userContext = userContext;
        }
        [HttpPost("ConfirmSalary")]
        public async Task<bool> ConfirmSalaryAsync(List<ConfirmSalaryDTO> confirmSalaryDTOs)
        {
            try
            {
                foreach (ConfirmSalaryDTO confirmSalaryDTO in confirmSalaryDTOs)
                {
                    if (confirmSalaryDTO.amount > 0)
                    {
                        RequestTransferDTO transferDTO = new RequestTransferDTO
                        {
                            beneId = confirmSalaryDTO.beneId.ToString(),
                            amount = (float)Math.Round(confirmSalaryDTO.amount, 2),
                            remarks = $"Salary {Convert.ToInt32(confirmSalaryDTO.amount)} is transfered for {confirmSalaryDTO.month} {confirmSalaryDTO.year}",
                            transferId = string.Format("{0}_{1}_{2}_{3}", confirmSalaryDTO.beneId, confirmSalaryDTO.month, confirmSalaryDTO.year, DateTime.Now.ToString("ddhhmmss"))
                        };
                        var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == confirmSalaryDTO.beneId);
                        if (staff != null)
                        {
                            if (!string.IsNullOrEmpty(staff.UpiId))
                            {
                                transferDTO.transferMode = "upi";
                            }
                            else
                            {
                                transferDTO.transferMode = "banktransfer";
                            }
                        }
                        if (cashFreeGateway.transferMoney(transferDTO))
                        {
                            if (!string.IsNullOrEmpty(staff.EmailID))
                            {
                                //var emailDetail = configuration.GetSection("Email");
                                //int port = int.Parse(emailDetail["SmtpPort"]);
                                //SmtpClient smtpClient = new SmtpClient(emailDetail["SmtpHost"], port);
                                //smtpClient.UseDefaultCredentials = false;

                                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                                //smtpClient.Credentials = new NetworkCredential(emailDetail["SmtpEmail"], emailDetail["SmtpPassword"]);
                                ////smtpClient.EnableSsl = true;
                                //MailMessage mailMessage = new MailMessage();
                                //mailMessage.From = new MailAddress(emailDetail["SmtpEmail"]);
                                //mailMessage.Subject = "Salary Credit Message";
                                //mailMessage.Body = transferDTO.remarks;
                                //mailMessage.To.Add(new MailAddress(staff.EmailID));
                                //mailMessage.BodyEncoding = UnicodeEncoding.Default;
                                //mailMessage.IsBodyHtml = false;
                                MailRequest mailRequest = new MailRequest();
                                mailRequest.Subject= "Salary Credit Message";
                                mailRequest.Body = transferDTO.remarks;
                                mailRequest.ToEmail = staff.EmailID;
                                await mailService.SendEmailAsync(mailRequest);
                                //EmailHelper.SendEmail(smtpClient, mailMessage);
                            }
                            tblConfirmedAttendence confirmedAttendence = new tblConfirmedAttendence
                            {
                                StaffId = confirmSalaryDTO.beneId,
                                AbsentDays = confirmSalaryDTO.AbsentDays,
                                ConfirmedBy = 1,
                                Isposted = true,
                                LeaveDays = confirmSalaryDTO.LeaveDays,
                                PresentDays = confirmSalaryDTO.PresentDays,
                                SalaryCalculated = confirmSalaryDTO.amount,
                                month = confirmSalaryDTO.month,
                                year = confirmSalaryDTO.year,
                                WorkingHrs = confirmSalaryDTO.WorkingHrs,
                                Error = string.Empty,
                                PostedOn = DateTime.Now
                            };
                            staffContext.tblConfirmedAttendences.Add(confirmedAttendence);
                            staffContext.SaveChanges();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        [HttpGet("GetSalaryByStaffId/{staffId}")]
        public List<tblConfirmedAttendence> GetSalaryByStaffId(int staffId)
        {
            return staffContext.tblConfirmedAttendences.Where(x => x.StaffId == staffId).ToList();
        }
        [HttpGet("GetSalaryByStaffIdYear/{staffId}/{year}")]
        public ApiResponse<List<tblConfirmedAttendence>> GetSalaryByStaffIdYear(int staffId,int year)
        {
            ApiResponse<List<tblConfirmedAttendence>> response = new ApiResponse<List<tblConfirmedAttendence>>();
            response.Data = null;
            try
            {
                int id = userContext.Id;
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == staffId);

                if (role == RolesConstant.ROLE_ADMIN || id == staffId || (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == staff.DepartmentID))
                {
                    var salaryReport = staffContext.tblConfirmedAttendences.Where(x => x.StaffId == staffId && x.year == year).ToList();

                    if (salaryReport.Count == 0)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else
                    {
                        response.IsSuccessfull = true;
                        response.Data = salaryReport;
                    }
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_INACCESSIBLE;
                }
            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            
            return response;
        }
        [HttpGet("GetSalaryByMonthYear/{month}/{year}")]
        public List<tblConfirmedAttendence> GetSalaryByMonthYear(int month, int year)
        {
            //DateTime startDate = new DateTime(year, month, 1);
            //int days=  DateTime.DaysInMonth(year, month);
            //DateTime endDate = new DateTime(year, month, days);
            return staffContext.tblConfirmedAttendences.Where(x => x.month == month && x.year == year).ToList();
        }
        [HttpGet("CalculateSalry/{month}/{year}")]
        public List<ConfirmSalaryView> CalculateSalry(int month, int year)
        {
            List<ConfirmSalaryView> confirmSalaryViews = new List<ConfirmSalaryView>();
            DateTime startDate = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            DateTime endDate = new DateTime(year, month, days);
            var confirmedAttendence = staffContext.tblConfirmedAttendences.Where(x => x.month==month && x.year==year).ToList();
            var monthAttendence = staffContext.tblAttendence.Where(x => x.myDate >= startDate && x.myDate <= endDate);
            var staffDetails = staffContext.tblStaff.Where(x => x.IsActive == true).OrderBy(x => x.DesignationID).ToList();
            var attendenceRule = staffContext.tblAttendenceRule.ToList();
            foreach (tblStaff staff in staffDetails)
            {
                if (confirmedAttendence.Any(x => x.StaffId == staff.ID))
                {
                    var staffConfirmDetails = confirmedAttendence.FirstOrDefault(x => x.StaffId == staff.ID);
                    confirmSalaryViews.Add(new ConfirmSalaryView()
                    {
                        StaffId = staff.ID,
                        StaffName = staff.StaffName,
                        PresentDays = staffConfirmDetails.PresentDays,
                        AbsentDays = staffConfirmDetails.AbsentDays,
                        LeaveDays = staffConfirmDetails.LeaveDays,
                        MonthlySalary = staff.Salary,
                        SalaryCalculated = staffConfirmDetails.SalaryCalculated,
                        IsConfirmed = staffConfirmDetails.Isposted
                    });
                }
                else
                {
                    var staffAttendenceRule = attendenceRule.FirstOrDefault(x => x.DesgId == staff.DesignationID);
                    if (staffAttendenceRule != null)
                    {
                        int present = 0, absent = 0, Leaves = 0;
                        present = monthAttendence.Where((x) => x.StaffID == staff.ID && x.Status == 'P').Count();
                        absent = monthAttendence.Where((x) => x.StaffID == staff.ID && x.Status == 'A').Count();
                        Leaves = monthAttendence.Where((x) => x.StaffID == staff.ID && x.Status == 'L').Count();
                        decimal salary = (decimal)((staff.Salary / days) * present);
                        absent = days - Leaves - present;
                        confirmSalaryViews.Add(new ConfirmSalaryView()
                        {
                            StaffId = staff.ID,
                            StaffName = staff.StaffName,
                            PresentDays = present,
                            AbsentDays = absent,
                            LeaveDays = Leaves,
                            MonthlySalary = staff.Salary,
                            SalaryCalculated = (float)salary,
                            IsConfirmed = false
                        });
                    }
                    else
                    {
                        confirmSalaryViews.Add(new ConfirmSalaryView()
                        {
                            StaffId = staff.ID,
                            StaffName = staff.StaffName,
                            PresentDays = 0,
                            AbsentDays = days,
                            LeaveDays = 0,
                            MonthlySalary = staff.Salary,
                            SalaryCalculated = 0,
                            IsConfirmed = false
                        });
                    }
                }
            }
            return confirmSalaryViews;
        }
    }
}
