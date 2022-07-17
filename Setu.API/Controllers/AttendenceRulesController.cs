using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttendenceRulesController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        UserContext userContext { get; set; }
        public AttendenceRulesController(StaffContext staffContext, UserContext userContext)
        {
            this.staffContext = staffContext;
            this.userContext = userContext;
            
        }
        // for all
        [HttpGet("GetAttendenceRules")]
        public ApiResponse<List<tblAttendenceRules>> GetAttendenceRules()
        {
            ApiResponse<List<tblAttendenceRules>> response = new ApiResponse<List<tblAttendenceRules>>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int desgId = userContext.DesignationID;
                List<tblAttendenceRules> rules = staffContext.tblAttendenceRule.Where(x=>role==RolesConstant.ROLE_ADMIN
                || role==RolesConstant.ROLE_DEPT_ADMIN || x.DesgId==desgId).Include(x => x.designation).ToList();
                if (rules.Count == 0)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                }                   
                else
                {
                    response.IsSuccessfull = true;
                    response.Data = rules;
                }
            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
        }
        // for master admin only or all ?
        [HttpGet("GetAttendenceRulesByDesg")]
        public ApiResponse<tblAttendenceRules> GetAttendenceRulesByDesg(int Id)
        {
            ApiResponse<tblAttendenceRules> response = new ApiResponse<tblAttendenceRules>();
            response.Data = null;
            
            try
            {
                string role = userContext.Role;
                int desgId = userContext.DesignationID;
                tblAttendenceRules rule = staffContext.tblAttendenceRule.FirstOrDefault(x =>(role==RolesConstant.ROLE_ADMIN
                || x.DesgId == desgId) && x.DesgId == Id);
                if (rule == null)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                }
                else
                {
                    response.IsSuccessfull = true;
                    response.Data = rule;
                }
            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
        }
        // master admin only
        [HttpPost("InsertAttendenceRules")]
        public ApiResponse<tblAttendenceRules> InsertAttendenceRules(tblAttendenceRules objtblAttendenceRules)
        {
            string role = userContext.Role;
            ApiResponse<tblAttendenceRules> response = new ApiResponse<tblAttendenceRules>();
            response.Data = null;
            try
            {
                if(role == RolesConstant.ROLE_ADMIN)
                {
                    staffContext.tblAttendenceRule.Add(objtblAttendenceRules);
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtblAttendenceRules;
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            
            return response;
        }
        private bool Exists(int id)
        {
            var rule = staffContext.tblAttendenceRule.FirstOrDefault(x => x.ID == id);
            if (rule != null)
                return true;
            else
                return false;
        }
        [HttpPost("UpdateAttendenceRules")]
        public ApiResponse<tblAttendenceRules> UpdateAttendenceRules(tblAttendenceRules objtblAttendenceRules)
        {
             ApiResponse<tblAttendenceRules> response = new ApiResponse<tblAttendenceRules>();
             response.Data = null;
            
            try
             {
                string role = userContext.Role;
                if (role == RolesConstant.ROLE_ADMIN)
                {
                    var existdata = staffContext.tblAttendenceRule.FirstOrDefault(x => x.ID == objtblAttendenceRules.ID);
                     if(existdata!=null)
                     {
                        existdata.RuleName = objtblAttendenceRules.RuleName;
                        existdata.DesgId = objtblAttendenceRules.DesgId;
                        existdata.designation = objtblAttendenceRules.designation;
                        existdata.WorkingHourDay = objtblAttendenceRules.WorkingHourDay;
                        existdata.WorkingHours = objtblAttendenceRules.WorkingHours;
                        existdata.SalaryCalculation = objtblAttendenceRules.SalaryCalculation;
                        existdata.SalaryCalculationDays = objtblAttendenceRules.SalaryCalculationDays;
                        existdata.LeavesAllowed = objtblAttendenceRules.LeavesAllowed;

                     staffContext.tblAttendenceRule.Update(existdata);
                     staffContext.SaveChanges();

                     response.IsSuccessfull = true;
                     response.Data = objtblAttendenceRules;
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
            catch (Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }           
            return response;
        }
    }
}
