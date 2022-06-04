using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class StaffController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        CashFreeGateway cashFreeGateway { get; set; }
        public StaffController(StaffContext staffContext, CashFreeGateway cashFreeGateway)
        {
            this.staffContext = staffContext;
            this.cashFreeGateway = cashFreeGateway;
        }
        [HttpGet("GetStaff")]
        public IList<tblStaff> GetStaff()
        {
            return staffContext.tblStaff.Include(x=>x.state).Include(x=>x.city).Include(x => x.designation).Include(x=>x.department).Include(x=>x.subject1).Include(x=>x.subject2).Include(x=>x.subject3).ToList();
        }

        [HttpGet("GetStaffForLogin")]
        public IList<tblStaff> GetStaffForLogin()
        {
            return staffContext.tblStaff.ToList();
        }


        [HttpGet("GetStaffByID/{id}")]
        public tblStaff GetStaffByID(int id)
        {
            return staffContext.tblStaff.FirstOrDefault(x => x.ID == id);
        }
        [HttpGet("GetStaffByEmailPassword/{email},{password}")]
        public tblStaff GetStaffByEmailPassword(string email,string password)
        {
            return staffContext.tblStaff.FirstOrDefault(x=> x.EmailID == email && x.Password == password);
        }
        [HttpPost("InsertStaff")]
        public tblStaff InsertStaff(tblStaff objtblStaff)
        {
            try
            {
                staffContext.tblStaff.Add(objtblStaff);
                staffContext.SaveChanges();
                AddBeneficiaryRequestDTO addBeneficiaryRequestDTO = new AddBeneficiaryRequestDTO();
                addBeneficiaryRequestDTO.email = objtblStaff.EmailID;
                addBeneficiaryRequestDTO.vpa = objtblStaff.UpiId;
                addBeneficiaryRequestDTO.phone = objtblStaff.MobileNo.ToString();
                addBeneficiaryRequestDTO.address1 = String.IsNullOrEmpty( objtblStaff.Address)? "NIT KUK" : objtblStaff.Address;
                addBeneficiaryRequestDTO.bankAccount = objtblStaff.AccountNo;
                addBeneficiaryRequestDTO.beneId = objtblStaff.StateID.ToString();
                addBeneficiaryRequestDTO.city = objtblStaff.CityID.ToString(); ;
                addBeneficiaryRequestDTO.ifsc = objtblStaff.IfscCode;
                addBeneficiaryRequestDTO.name = objtblStaff.StaffName;
                addBeneficiaryRequestDTO.pincode = "125055";
                addBeneficiaryRequestDTO.state = objtblStaff.StateID.ToString();
                if(!cashFreeGateway.addBenificiary(addBeneficiaryRequestDTO))
                {
                    staffContext.tblStaff.Remove(objtblStaff);
                    staffContext.SaveChanges();
                    objtblStaff = null;
                }
                return objtblStaff;
            }
            catch(Exception e)
            {
                return null;
            }
        }
        [HttpPost("UpdateStaff")]
        public tblStaff UpdateStaff(tblStaff objtblStaff)
        {
            staffContext.tblStaff.Update(objtblStaff);
            staffContext.SaveChanges();
            return objtblStaff;
        }

        [HttpDelete("DeleteStaff/{id}")]
        public ApiResponse<Boolean> DeleteStaff(int id)
        {
            try
            {
                //tblStaff tbl = staffContext.tblStaff.FirstOrDefault(x => x.ID == id);
                tblStaff tbl = GetStaffByID(id);

                ApiResponse<Boolean> result = new ApiResponse<Boolean>();
                result.Data = false ;

                if(tbl == null)
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = "Staff does not exist";
                }
                else if (tbl.IsActive == false)
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = "Staff already deleted";
                }
                else
                {
                    tbl.IsActive = false;
                    UpdateStaff(tbl);
                    result.IsSuccessfull = true;
                    result.ErrorMessage = "Staff Successfully Deleted";
                }              
                return result;
            }
            catch(Exception e)
            {
                ApiResponse<Boolean> result = new ApiResponse<Boolean>();
                result.Data = false;
                result.IsSuccessfull = false;
                result.ErrorMessage = e.Message;
                return result;
            }

        }
    }
}
