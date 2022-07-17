using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Setu.API.JwtRepository;
using Setu.API.Models;
using Setu.API.PaymenGatewayHelper.Cashfree;
using Setu.Common.DTO;
using Setu.Common;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StaffController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        CashFreeGateway cashFreeGateway { get; set; }
        UserContext userContext { get; set; }

        //private readonly IJWTManager jWTManager;
        public StaffController(StaffContext staffContext, CashFreeGateway cashFreeGateway, UserContext userContext)
        {
            this.staffContext = staffContext;
            this.cashFreeGateway = cashFreeGateway;
            this.userContext = userContext;
            
        }
        [HttpGet("GetStaffForLogin")]
        [AllowAnonymous]
        public ApiResponse<List<tblStaff>> GetStaffForLogin()
        {
            ApiResponse<List<tblStaff>> response = new ApiResponse<List<tblStaff>>();

            var staff = staffContext.tblStaff.Where(x => x.IsActive == true).ToList();
            if(staff.Count !=0)
            {
                response.IsSuccessfull = true;
                response.Data = staff;
            }
            else
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
            }
            return response;
        }

        [HttpGet("GetStaff")]   
     //   [Authorize(Roles = "Admin")]
     // not for staff
        public ApiResponse<List<tblStaff>> GetStaff()
        {
            ApiResponse<List<tblStaff>> response = new ApiResponse<List<tblStaff>>();
            response.Data = null;
            int deptid = userContext.DepartmentID;
            string role = userContext.Role;
            try
            {
                List<tblStaff> tbls = new List<tblStaff>();
                if(role == RolesConstant.ROLE_STAFF)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_INACCESSIBLE;
                }
                else
                {
                    tbls = staffContext.tblStaff.Include(x => x.state)
                    .Include(x => x.city).Include(x => x.designation).Include(x => x.department)
                    .Include(x => x.subject1).Include(x => x.subject2).Include(x => x.subject3)
                    .Where(x => (role == RolesConstant.ROLE_ADMIN || x.DepartmentID == deptid) && x.IsActive == true).ToList();

                    if (tbls == null)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else
                    {
                        response.IsSuccessfull = true;
                        response.Data = tbls;
                    }
                }
                
            }
            catch(Exception e)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
        }
        // staff can access only its own info
        [HttpGet("GetStaffByID/{id}")]
        public ApiResponse<tblStaff> GetStaffByID(int id)
        {
            int deptid = userContext.DepartmentID;
            string role = userContext.Role;
            int Id = userContext.Id;
            ApiResponse<tblStaff> response = new ApiResponse<tblStaff>();
            response.Data = null;
            try
            {
                tblStaff tbl = FindStaffByID(id);
                
                if(tbl == null)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                }
                else if(role==RolesConstant.ROLE_ADMIN || id==Id ||
                    (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == tbl.DepartmentID))
                {
                    response.IsSuccessfull = true;
                    response.Data = tbl;
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_INACCESSIBLE;
                  
                }
            }
            catch(Exception e)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
                //response.ErrorMessage = e.Message;
            }
            return response;
        }
        private tblStaff FindStaffByID(int id)
        {
            string role = userContext.Role;
            int deptid = userContext.DepartmentID;
            int Id = userContext.Id;
            return staffContext.tblStaff.Include(x => x.state)
                    .Include(x => x.city).Include(x => x.designation).Include(x => x.department)
                    .Include(x => x.subject1).Include(x => x.subject2).Include(x => x.subject3).FirstOrDefault(x => x.ID == id && x.IsActive == true);
            //return staffContext.tblStaff.FirstOrDefault(x => (role==RolesConstant.ROLE_ADMIN || id==Id || x.DepartmentID==deptid) && x.ID == id && x.IsActive ==true);
        }
        // not for staff
        [HttpPost("InsertStaff")]
        public ApiResponse<tblStaff> InsertStaff(tblStaff objtblStaff)
        {
            int deptid = userContext.DepartmentID;
            string role = userContext.Role;
            ApiResponse<tblStaff> response = new ApiResponse<tblStaff>();
            response.Data = null;
            try
            {
                if (role!=RolesConstant.ROLE_ADMIN && objtblStaff.DepartmentID != deptid)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
                else
                {
                    objtblStaff.IsActive = true;
                    staffContext.tblStaff.Add(objtblStaff);
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtblStaff;
               
                        AddBeneficiaryRequestDTO addBeneficiaryRequestDTO = new AddBeneficiaryRequestDTO();
                        addBeneficiaryRequestDTO.email = objtblStaff.EmailID;
                        addBeneficiaryRequestDTO.vpa = objtblStaff.UpiId;
                        addBeneficiaryRequestDTO.phone = objtblStaff.MobileNo.ToString();
                        addBeneficiaryRequestDTO.address1 = string.IsNullOrEmpty(objtblStaff.Address) ? "NIT KUK" : objtblStaff.Address;
                        addBeneficiaryRequestDTO.bankAccount = objtblStaff.AccountNo;
                        addBeneficiaryRequestDTO.beneId = objtblStaff.ID.ToString();
                        addBeneficiaryRequestDTO.city = staffContext.tblCity.FirstOrDefault(x => x.ID == objtblStaff.CityID).CityName;
                        addBeneficiaryRequestDTO.ifsc = objtblStaff.IfscCode;
                        addBeneficiaryRequestDTO.name = objtblStaff.StaffName;
                        addBeneficiaryRequestDTO.pincode = "125055";
                        addBeneficiaryRequestDTO.state = staffContext.tblState.FirstOrDefault(x => x.ID == objtblStaff.StateID).StateName;
                        if (!cashFreeGateway.addBenificiary(addBeneficiaryRequestDTO))
                        {
                            staffContext.tblStaff.Remove(objtblStaff);
                            staffContext.SaveChanges();
                            response.IsSuccessfull = false;
                            response.ErrorMessage = ApiResponseConstants.MESSAGE_BENIFICIARY_FAILURE;
                            response.Data = null;
                            //objtblStaff = null;
                        }
                   
                }
            }
            catch(Exception e)
            {
                //return null;
                if(response.IsSuccessfull == true)
                {
                    staffContext.tblStaff.Remove(objtblStaff);
                    staffContext.SaveChanges();
                    response.ErrorMessage = e.Message;
                    response.Data = null;
                }
                else
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
                response.IsSuccessfull = false;
                
            }
            return response;

        }
        [HttpPost("UpdateStaff")]
        public ApiResponse<tblStaff> UpdateStaff(tblStaff objtblStaff)
        {
            int deptid = userContext.DepartmentID;
            string role = userContext.Role;
            int id = userContext.Id;
            ApiResponse<tblStaff> response = new ApiResponse<tblStaff>();
            response.Data = null;
            
            try
            {              
                if(role == RolesConstant.ROLE_ADMIN || (role == RolesConstant.ROLE_STAFF && (objtblStaff.ID == id)) ||
                    (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == objtblStaff.DepartmentID))
                {
                    var existData = FindStaffByID(objtblStaff.ID);
                    if(existData!=null)
                    {
                        existData.StaffName = objtblStaff.StaffName;
                        existData.FatherName = objtblStaff.FatherName;
                        existData.MotherName = objtblStaff.MotherName;
                        existData.Gender = objtblStaff.Gender;
                        existData.Dob = objtblStaff.Dob;
                        existData.Category = objtblStaff.Category;
                        existData.StateID = objtblStaff.StateID;
                       // existData.state = objtblStaff.state;
                        existData.CityID = objtblStaff.CityID;
                       // existData.city = objtblStaff.city;
                        existData.Address = objtblStaff.Address;
                        existData.EmailID = objtblStaff.EmailID;
                        existData.Password = objtblStaff.Password;
                        existData.MobileNo = objtblStaff.MobileNo;
                        existData.Qualification = objtblStaff.Qualification;
                        existData.Role = objtblStaff.Role;
                        existData.DesignationID = objtblStaff.DesignationID;
                       // existData.designation = objtblStaff.designation;
                        existData.DepartmentID = objtblStaff.DepartmentID;
                     //   existData.department = objtblStaff.department;
                        existData.Subject1ID = objtblStaff.Subject1ID;
                        existData.Subject2ID = objtblStaff.Subject2ID;
                        existData.Subject3ID = objtblStaff.Subject3ID;
                       // existData.subject1 = objtblStaff.subject1;
                       // existData.subject2 = objtblStaff.subject2;
                      //  existData.subject3 = objtblStaff.subject3;
                        existData.Salary = objtblStaff.Salary;
                        existData.JoiningDate = objtblStaff.JoiningDate;
                        existData.Experience = objtblStaff.Experience;
                        if (!string.IsNullOrEmpty(objtblStaff.FingerPrintdata))
                            existData.FingerPrintdata = objtblStaff.FingerPrintdata;
                        if (!string.IsNullOrEmpty(objtblStaff.FingerPrintANSI))
                            existData.FingerPrintANSI = objtblStaff.FingerPrintANSI;
                        existData.AccountNo = objtblStaff.AccountNo;
                        existData.AccountName = objtblStaff.AccountName;
                        existData.IfscCode = objtblStaff.IfscCode;
                        existData.UpiId = objtblStaff.UpiId;
                        existData.IsActive = objtblStaff.IsActive;

                        staffContext.tblStaff.Update(existData);
                        staffContext.SaveChanges();

                        response.IsSuccessfull = true;
                        response.Data = objtblStaff;
                    }
                    else
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                                      
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
            }
            catch(Exception e )
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
           
            return response;
        }
        private bool Exits(int id)
        {
            var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == id);
            if (staff == null)
                return false;
            else
                return true;
        }
        [HttpDelete("DeleteStaff/{id}")]
        public ApiResponse<Boolean> DeleteStaff(int id)
        {
            ApiResponse<Boolean> response = new ApiResponse<Boolean>();
            response.Data = false;

            try
            {
                int deptid = userContext.DepartmentID;
                string role = userContext.Role;
                //tblStaff tbl = staffContext.tblStaff.FirstOrDefault(x => x.ID == id);
                tblStaff tblStaff = FindStaffByID(id);              

                if(role == RolesConstant.ROLE_ADMIN || role==RolesConstant.ROLE_DEPT_ADMIN && deptid == tblStaff.DepartmentID)
                {
                    if (tblStaff == null)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else if (tblStaff.IsActive == false)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_ALREADY_DELETED;
                    }
                    else
                    {
                        tblStaff.IsActive = false;
                        var res = UpdateStaff(tblStaff);
                        response.IsSuccessfull = res.IsSuccessfull;
                        response.ErrorMessage = res.ErrorMessage;
                    }
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
                        
                
            }
            catch(Exception e)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;               
            }
            return response;
        }
    }
}
