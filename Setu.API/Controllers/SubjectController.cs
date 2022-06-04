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
    public class SubjectController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        public SubjectController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }
        [HttpGet("GetSubject")]
        public IList<tblSubject> GetSubject()
        {
            return staffContext.tblSubject.OrderBy(x => x.DeptID).ToList();
        }
        [HttpGet("GetSubjectByDepartmentID/{id}")]
        public IList<tblSubject> GetSubjectByDepartmentID(int id)
        {
            return staffContext.tblSubject.Where(x => x.DeptID == id).ToList();

        }

        [HttpGet("GetSubjectByID/{id}")]
        public tblSubject GetSubjectByID(int id)
        {
            return staffContext.tblSubject.FirstOrDefault(x => x.ID == id);

        }
        [HttpPost("InsertSubject")]
        public tblSubject InsertSubject(tblSubject objtblSubject)
        {
            staffContext.tblSubject.Add(objtblSubject);
            staffContext.SaveChanges();
            return objtblSubject;
        }

        [HttpPost("UpdateSubject")]
        public tblSubject UpdateSubject(tblSubject objtblSubject)
        {
            staffContext.tblSubject.Update(objtblSubject);
            staffContext.SaveChanges();
            return objtblSubject;
        }

        [HttpDelete("DeleteSubject/{id}")]
        public ApiResponse<Boolean> DeleteSubject(int id)
        {
            try
            {
                tblSubject tbl = GetSubjectByID(id);

                ApiResponse<Boolean> result = new ApiResponse<Boolean>();
                result.Data = false;

                if (tbl == null)
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = "Subject does not exist";
                }
                else if (tbl.IsActive == false)
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = "Subject already deleted";
                }
                else
                {
                    tbl.IsActive = false;
                    UpdateSubject(tbl);
                    result.IsSuccessfull = true;
                    result.ErrorMessage = "Subject Successfully Deleted";
                }
                return result;
            }
            catch (Exception e)
            {
                ApiResponse<Boolean> result = new ApiResponse<Boolean>();
                result.Data = false;
                result.IsSuccessfull = false;
                result.ErrorMessage = e.Message;
                return result;
            }
        }

        [HttpDelete("DeleteSubjectByDepartmentID/{id}")]
        public ApiResponse<Boolean> DeleteSubjectByDepartmentID(int id)
        {
            try
            {

            }
            catch(Exception e)
            {

            }
        }
    }
}
