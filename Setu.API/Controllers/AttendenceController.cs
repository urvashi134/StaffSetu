using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.Entities;
using Setu.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttendenceController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        UserContext userContext { get; set; }
        public AttendenceController(StaffContext staffContext,UserContext userContext)
        {
            this.staffContext = staffContext;
            this.userContext = userContext;
        }
        [HttpGet("GetAttendenceByStaffIdMonthYear/{obj}")]
        public ApiResponse<List<tblAttendence>> GetAttendenceByStaffIdMonthYear(UserAttendenceReport obj)
        {          
            ApiResponse<List<tblAttendence>> response = new ApiResponse<List<tblAttendence>>();
            response.Data = null;
            try
            {
                int id = userContext.Id;
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == obj.StaffId);
                
                if (role == RolesConstant.ROLE_ADMIN || id == obj.StaffId || (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == staff.DepartmentID))
                {
                    var val = staffContext.tblAttendence.Where(x => x.StaffID == obj.StaffId && x.myDate >= obj.AttendenceFrom && x.myDate <= obj.AttendenceTill).ToList();
                    if (val.Count == 0)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else
                    {
                        response.IsSuccessfull = true;
                        response.Data = val;
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
        [HttpGet("GetAttendenceByMonthYear/{obj}")]
        public ApiResponse<List<tblAttendence>> GetAttendenceByMonthYear(UserAttendenceReport obj)
        {
            ApiResponse<List<tblAttendence>> response = new ApiResponse<List<tblAttendence>>();
            response.Data = null;

            try
            {
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                if(role == RolesConstant.ROLE_STAFF)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
                else 
                {
                    var staff = staffContext.tblStaff.Where(x => x.DepartmentID == deptid).ToList();
                    

                }
                var val = staffContext.tblAttendence.Where(x => x.myDate >= obj.AttendenceFrom && x.myDate <= obj.AttendenceTill).GroupBy(c => new
                {
                    c.StaffID,
                    c.Status
                }).Select(gcs => new
                {
                    StaffId = gcs.Key.StaffID,
                    Status = gcs.Key.Status,
                    TotalCount = gcs.Count(),
                }).ToList();

                //return (IList<tblAttendence>)val;

            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }

            //int count = val.Count;
            return response;
        }
        // 
        [HttpPost("GetAttendenceByStaffIdDate")]
        public ApiResponse<tblAttendence> GetAttendenceByStaffIdDate(AttendenceRules obj)
        {           
            ApiResponse<tblAttendence> response = new ApiResponse<tblAttendence>();
            response.Data = null;
            try
            {
                int id = userContext.Id;
                string role = userContext.Role;
                int deptid = userContext.DepartmentID;
                var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == obj.staffId);

                if(staff == null)
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_STAFF_NOT_EXISTING; 
                }
                else
                {
                    if (role == RolesConstant.ROLE_ADMIN || id == obj.staffId || (role == RolesConstant.ROLE_DEPT_ADMIN && deptid == staff.DepartmentID))
                    {
                        var attendence = staffContext.tblAttendence.FirstOrDefault(x => x.StaffID == obj.staffId && x.myDate == obj.date);

                        if (attendence == null)
                        {
                            response.IsSuccessfull = false;
                            response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                        }
                        else
                        {
                            response.IsSuccessfull = true;
                            response.Data = attendence;
                        }
                    }
                    else
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_INACCESSIBLE;
                    }
               }
                           
            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
        }
        [HttpPost("InsertAttendence")]
        public ApiResponse<tblAttendence> InsertAttendence(tblAttendence objtblAttendence)
        {
            ApiResponse<tblAttendence> response = new ApiResponse<tblAttendence>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int deptId = userContext.DepartmentID;
                int id = userContext.Id;
                var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == objtblAttendence.StaffID);
                
                if(role==RolesConstant.ROLE_ADMIN || (role==RolesConstant.ROLE_DEPT_ADMIN && deptId==staff.DepartmentID && id!=objtblAttendence.StaffID))
                {
                    staffContext.tblAttendence.Add(objtblAttendence);
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtblAttendence;
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
        // not for staff
        [HttpPost("UpdateAttendence")]
        public ApiResponse<tblAttendence> UpdateAttendence(tblAttendence objtblAttendence)
        {
            ApiResponse<tblAttendence> response = new ApiResponse<tblAttendence>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                int deptId = userContext.DepartmentID;
                int id = userContext.Id;
                var staff = staffContext.tblStaff.FirstOrDefault(x => x.ID == objtblAttendence.StaffID);

                if (role == RolesConstant.ROLE_ADMIN || (role == RolesConstant.ROLE_DEPT_ADMIN && deptId == staff.DepartmentID && id != objtblAttendence.StaffID))
                {
                    staffContext.tblAttendence.Update(objtblAttendence);
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtblAttendence;
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
        // not for staff
        [HttpPost("Insert_Update_Attendence")]
        public ApiResponse<bool> Insert_Update_Attendence(List<tblAttendence> tblAttendences)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            try
            {
                foreach(tblAttendence tblAttendence in tblAttendences)
                {
                    if(tblAttendence.ID == 0)
                    {
                        staffContext.tblAttendence.Add(tblAttendence);
                    }
                    else
                    {
                        staffContext.tblAttendence.Update(tblAttendence);
                    }
                }
                staffContext.SaveChanges();
                response.IsSuccessfull = true;
                response.Data = true;
            }
            catch(Exception ex)
            {
                response.IsSuccessfull = false;
                response.Data = false;
            }

            return response;
        }
        
        [HttpPost("GetAttendenceByDate")]
        public ApiResponse< List<AttendenceRegisterResponseDTO>> GetAttendenceByDate(AttendenceRules obj)
        {
            ApiResponse<List<AttendenceRegisterResponseDTO>> response = new ApiResponse<List<AttendenceRegisterResponseDTO>>();
            List<AttendenceRegisterResponseDTO> attendenceRegisterResponseDTOs = new List<AttendenceRegisterResponseDTO>();
            try
            {
                string role = userContext.Role;
                int deptId = userContext.DepartmentID;
                int id = userContext.Id;

                var dayAttendence = staffContext.tblAttendence.Where(x => x.myDate == obj.date.Date);
                foreach (tblStaff staff in staffContext.tblStaff.Where(x=> (role==RolesConstant.ROLE_ADMIN || role==RolesConstant.ROLE_DEPT_ADMIN && deptId == x.DepartmentID && x.ID!=id) && x.IsActive==true).ToList())
                {
                    AttendenceRegisterResponseDTO attendenceRegisterResponseDTO = new AttendenceRegisterResponseDTO
                    {
                        StaffID = staff.ID,
                        StaffName = staff.StaffName
                    };
                    var staffDayAttendence = dayAttendence.FirstOrDefault(x => x.StaffID == staff.ID);
                    if (staffDayAttendence != null)
                    {
                        attendenceRegisterResponseDTO.ID = staffDayAttendence.ID;
                        attendenceRegisterResponseDTO.Status = staffDayAttendence.Status == 'P' ? "Present" : staffDayAttendence.Status == 'A' ? "Absent" : "Leave";
                        attendenceRegisterResponseDTO.StartTime = staffDayAttendence.StartTime;
                        attendenceRegisterResponseDTO.EndTime = staffDayAttendence.EndTime;
                    }
                    attendenceRegisterResponseDTOs.Add(attendenceRegisterResponseDTO);
                }
                response.IsSuccessfull = true;
                response.Data = attendenceRegisterResponseDTOs;
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
