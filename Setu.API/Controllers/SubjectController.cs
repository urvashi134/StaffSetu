using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class SubjectController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        UserContext userContext { get; set; }
        public SubjectController(StaffContext staffContext, UserContext userContext)
        {
            this.staffContext = staffContext;
            this.userContext = userContext;
        }
        // for all ??
        [HttpGet("GetSubject")]
        public ApiResponse<List<SubjectView>> GetSubject()
        {
            
            ApiResponse<List<SubjectView>> response = new ApiResponse<List<SubjectView>>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                List<SubjectView> subjects = new List<SubjectView>();
                var subjectDetails = staffContext.tblSubject.Where(x => (role == RolesConstant.ROLE_ADMIN || x.DeptID == deptid) && x.IsActive == true).OrderBy(x => x.DeptID).ToList();
                
                if(subjectDetails != null)
                {
                    var deptIds = subjectDetails.Select(x => x.DeptID).Distinct();
                    var deptNames = staffContext.tbldepartment.Where(x => deptIds.Contains(x.ID)).ToList();
                    foreach (var subject in subjectDetails)
                    {
                        string deptName = deptNames.FirstOrDefault(x => x.ID == subject.DeptID).Name;
                        if (deptName != null)
                        {
                            subjects.Add(new SubjectView()
                            {
                                ID = subject.ID,
                                SubjectName = subject.SubjectName,
                                DeptName = deptName
                            });
                        }
                    }
                    response.IsSuccessfull = true;
                    response.Data = subjects;
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                }
            }
            catch (Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }

            return response;
        }
        [HttpGet("GetSubjectByDepartmentID/{id}")]
        public ApiResponse<List<tblSubject>> GetSubjectByDepartmentID(int id)
        {
            
            ApiResponse<List<tblSubject>> response = new ApiResponse<List<tblSubject>>();
            response.Data = null;

            try
            {
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                if (role==RolesConstant.ROLE_ADMIN || deptid == id)
                {
                    var tbl = staffContext.tblSubject.Where(x => x.DeptID == id && x.IsActive == true).ToList();
                    if(tbl.Count == 0)
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

       
        private tblSubject GetSubjectByID(int id)
        {
            return staffContext.tblSubject.FirstOrDefault(x => x.ID == id);

        }
        [HttpPost("InsertSubject")]
        public ApiResponse<tblSubject> InsertSubject(tblSubject objtblSubject)
        {
           
            ApiResponse<tblSubject> response = new ApiResponse<tblSubject>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;

                if (role == RolesConstant.ROLE_ADMIN || (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == objtblSubject.DeptID))
                {
                    objtblSubject.IsActive = true;
                    staffContext.tblSubject.Add(objtblSubject);
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtblSubject;                  
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

        [HttpPost("UpdateSubject")]
        public ApiResponse<tblSubject> UpdateSubject(tblSubject objtblSubject)
        {           
            ApiResponse<tblSubject> response = new ApiResponse<tblSubject>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;

                if (role == RolesConstant.ROLE_ADMIN || (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == objtblSubject.DeptID))
                {
                    var existData = GetSubjectByID(objtblSubject.ID);
                    if (existData!=null)
                    {
                        existData.SubjectName = objtblSubject.SubjectName;
                        existData.DeptID = objtblSubject.DeptID;
                        existData.IsActive = objtblSubject.IsActive;
                        staffContext.tblSubject.Update(existData);
                        staffContext.SaveChanges();

                        response.IsSuccessfull = true;
                        response.Data = objtblSubject;
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
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
           
            return response;            

        }
      
        [HttpDelete("DeleteSubject/{id}")]
        public ApiResponse<Boolean> DeleteSubject(int id)
        {
            ApiResponse<Boolean> result = new ApiResponse<Boolean>();
            result.Data = false;
            try
            {
                tblSubject tblSubject = GetSubjectByID(id);               
                string role = userContext.Role;
                int deptId = userContext.Id;

                if(role == RolesConstant.ROLE_ADMIN || tblSubject.DeptID == deptId)
                {
                    if (tblSubject == null)
                    {
                        result.IsSuccessfull = false;
                        result.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else if (tblSubject.IsActive == false)
                    {
                        result.IsSuccessfull = false;
                        result.ErrorMessage = ApiResponseConstants.MESSAGE_ALREADY_DELETED;
                    }
                    else
                    {
                        tblSubject.IsActive = false;
                        var res = UpdateSubject(tblSubject);
                        result.IsSuccessfull = res.IsSuccessfull;
                        result.ErrorMessage = res.ErrorMessage;
                    }
                }
                else
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
            }
            catch (Exception e)
            {                
                result.IsSuccessfull = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }
    }
}
