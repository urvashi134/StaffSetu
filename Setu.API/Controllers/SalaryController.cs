using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.API.PaymenGatewayHelper.Cashfree;
using Setu.Common.DTO;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        CashFreeGateway cashFreeGateway { get; set; }
        public SalaryController(CashFreeGateway cashFreeGateway, StaffContext staffContext)
        {
            this.staffContext = staffContext;
            this.cashFreeGateway = cashFreeGateway;
        }
        [HttpPost("ConfirmSalary")]
        public void ConfirmSalary(ConfirmSalaryDTO confirmSalaryDTO)
        {
            RequestTransferDTO transferDTO = new RequestTransferDTO
            {
                beneId = confirmSalaryDTO.beneId.ToString(),
                amount = confirmSalaryDTO.amount,
                remarks = $"Salary {confirmSalaryDTO.amount} is transfered for {confirmSalaryDTO.month}/{confirmSalaryDTO.year}",
                transferId = string.Format("{0}_{1}_{2}", confirmSalaryDTO.beneId, confirmSalaryDTO.month, confirmSalaryDTO.year)
            };
            var staff= staffContext.tblStaff.FirstOrDefault(x => x.ID == confirmSalaryDTO.beneId);
            if (staff != null)
            {
                if (string.IsNullOrEmpty(staff.UpiId))
                {
                    transferDTO.transferMode = "upi";
                }
                else
                {
                    transferDTO.transferMode = "banktransfer";
                }
            }
            this.cashFreeGateway.transferMoney(transferDTO);
        }

        [HttpGet("GetSalaryByStaffId/{staffId}")]
        public List<tblConfirmedAttendence> GetSalaryByStaffId(int staffId)
        {
            return staffContext.tblConfirmedAttendences.Where(x => x.StaffId == staffId).ToList();
        }
        [HttpGet("GetSalaryByStaffIdYear/{staffId}/{year}")]
        public List<tblConfirmedAttendence> GetSalaryByStaffIdYear(int staffId,int year)
        {
            return staffContext.tblConfirmedAttendences.Where(x => x.StaffId == staffId && x.year==year).ToList();
        }
        [HttpGet("GetSalaryByMonthYear/{month}/{year}")]
        public List<tblConfirmedAttendence> GetSalaryByMonthYear(int month, int year)
        {
            //DateTime startDate = new DateTime(year, month, 1);
            //int days=  DateTime.DaysInMonth(year, month);
            //DateTime endDate = new DateTime(year, month, days);
            return staffContext.tblConfirmedAttendences.Where(x => x.month == month && x.year == year).ToList();
        }
        [HttpPost("CalculateSalry")]
        public List<ConfirmSalaryView> CalculateSalry(int month, int year)
        {
            List<ConfirmSalaryView> confirmSalaryViews = new List<ConfirmSalaryView>();
            DateTime startDate = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            DateTime endDate = new DateTime(year, month, days);
            var monthAttendence = staffContext.tblAttendence.Where(x => x.myDate >= startDate && x.myDate <= endDate);
            var staffDetails = staffContext.tblStaff.OrderBy(x => x.DesignationID).ToList();
            var attendenceRule = staffContext.tblAttendenceRule.ToList();
            foreach (tblStaff staff in staffDetails)
            {
                var staffAttendenceRule = attendenceRule.FirstOrDefault(x => x.DesgId == staff.DesignationID);
                if (staffAttendenceRule != null)
                {
                    int present = 0, absent = 0, Leaves = 0;
                    present = monthAttendence.Where((x) => x.StaffID == staff.ID && x.Status == 'P').Count();
                    absent = monthAttendence.Where((x) => x.StaffID == staff.ID && x.Status == 'A').Count();
                    Leaves = monthAttendence.Where((x) => x.StaffID == staff.ID && x.Status == 'L').Count();
                    decimal salary = (decimal)((staff.Salary / days) * present);

                    confirmSalaryViews.Add(new ConfirmSalaryView()
                    {
                        StaffId = staff.ID,
                        StaffName = staff.StaffName,
                        PresentDays = present,
                        AbsentDays= absent,
                        LeaveDays= Leaves,
                        MonthlySalary = staff.Salary,
                        SalaryCalculated = salary
                    });
                }
            }
            return confirmSalaryViews;
        }
    }
}
