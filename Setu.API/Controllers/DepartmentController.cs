using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DepartmentController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        UserContext userContext { get; set; }

        public DepartmentController(StaffContext staffContext, UserContext userContext)
        {
            this.staffContext = staffContext;
            this.userContext = userContext;
        }

        // for all ??
       [HttpGet("GetDepartment")]
       public ApiResponse<List<tbldepartment>> GetDepartment()
        {
            ApiResponse<List<tbldepartment>> response = new ApiResponse<List<tbldepartment>>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                List<tbldepartment> tbl = staffContext.tbldepartment.Where(x => (role == RolesConstant.ROLE_ADMIN || x.ID == deptid) && x.IsActive == true).ToList();

                if (tbl == null)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                }
                    
                else
                {
                    response.IsSuccessfull = true;
                    response.Data = tbl;
                }
            }
            catch (Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
        }    
        // not for staff
        [HttpGet("GetDepartmentByID/{id}")]
        public ApiResponse<tbldepartment> GetDepartmentByID(int id)
        {
            
            ApiResponse<tbldepartment> response = new ApiResponse<tbldepartment>();
            response.Data = null;
            try
            {
                int deptid = userContext.DepartmentID;
                string role = userContext.Role;
                if (role == RolesConstant.ROLE_ADMIN || deptid == id)
                {
                    var tbl = FindDepartmentfByID(id);
                    if (tbl == null)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else
                    {
                        response.IsSuccessfull = true;
                        response.Data = tbl;
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
        private tbldepartment FindDepartmentfByID(int id)
        {
            int deptid = userContext.DepartmentID;
            string role = userContext.Role;
            return staffContext.tbldepartment.FirstOrDefault(x => x.ID == id);
        }
        /*public void GetDepartment()
        {
            var departmentDetail = staffContext.tblDepartments.ToList();
        }*/
        // only for master admin ??
        [HttpPost("InsertDepartment")]
        public ApiResponse<tbldepartment> InsertDepartment(tbldepartment objtbldepartment)
        {
            int deptid = userContext.DepartmentID;
            ApiResponse<tbldepartment> response = new ApiResponse<tbldepartment>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                if (role == RolesConstant.ROLE_ADMIN)
                {
                    objtbldepartment.IsActive = true;
                    staffContext.tbldepartment.Add(objtbldepartment); ;
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtbldepartment;
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
        // only master admin
        [HttpPost("UpdateDepartment")]
        public ApiResponse<tbldepartment> UpdateDepartment(tbldepartment objtbldepartment)
        {
            int deptid = userContext.DepartmentID;
            string role = userContext.Role;
            ApiResponse<tbldepartment> response = new ApiResponse<tbldepartment>();
            response.Data = null;          
            try
            {
                if (role == RolesConstant.ROLE_ADMIN)
                {
                    var existdata = Exists(objtbldepartment.ID);
                    if (existdata != null)
                    {
                       // existdata = objtbldepartment;
                        existdata.Name = objtbldepartment.Name;
                        existdata.Location = objtbldepartment.Location;
                        existdata.IsActive = objtbldepartment.IsActive;
                        staffContext.tbldepartment.Update(existdata);
                        staffContext.SaveChanges();

                        response.IsSuccessfull = true;
                        response.Data = objtbldepartment;
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
            catch(DbUpdateConcurrencyException e)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = e.Message;
            }
            catch (Exception e)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = e.Message;
            }
            return response;
        }
        private tbldepartment Exists(int id)
        {
            var dept = staffContext.tbldepartment.FirstOrDefault(x => x.ID == id);
            //if (dept==null)
            //    return false;
            //else
            //    return true;
            return dept;
        }
        private List<tblSubject> FindActiveSubjects(int id)
        {
            return staffContext.tblSubject.Where(x => x.DeptID == id && x.IsActive == true).ToList();
        }
        // only for master admin ??
        [HttpDelete("DeleteDepartment/{id}")]
        public ApiResponse<Boolean> DeleteDepartment(int id)
        {
           
            ApiResponse<bool> result = new ApiResponse<bool>
            {
                Data = false
            };
            try
            {
                string role = userContext.Role;

                if (role == RolesConstant.ROLE_ADMIN)
                {
                    tbldepartment department = FindDepartmentfByID(id);
                    if (department == null || department.IsActive == false)
                    {
                        result.IsSuccessfull = false;
                        result.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }                    
                    else
                    {
                        List<tblSubject> subjects = FindActiveSubjects(id);
                        if(subjects.Count==0)
                        {
                            department.IsActive = false;
                            var response = UpdateDepartment(department);
                            result.IsSuccessfull = response.IsSuccessfull;
                            result.ErrorMessage = response.ErrorMessage;
                        }
                        else
                        {
                            result.IsSuccessfull = false;
                            result.ErrorMessage = "Deleting related subjects required";
                        }
                        
                    }
                }
                else
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
                
            }
            catch (Exception)
            {              
                result.IsSuccessfull = false;
                result.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return result;
        }
    }
}
