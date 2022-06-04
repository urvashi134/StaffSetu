using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        StaffContext staffContext { get; set; }

        public DepartmentController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }
       [HttpGet("GetDepartment")]
        public IList<tbldepartment> GetDepartment()
        {
            return (staffContext.tbldepartment.ToList());
        }

        [HttpGet("GetDepartmentByID/{id}")]
        public tbldepartment GetDepartmentByID(int id)
        {
            return staffContext.tbldepartment.FirstOrDefault(x => x.ID == id);
        }

        /*public void GetDepartment()
        {
            var departmentDetail = staffContext.tblDepartments.ToList();
        }*/
        [HttpPost("InsertDepartment")]
        public tbldepartment InsertDepartment(tbldepartment objtbldepartment)
        {
            staffContext.tbldepartment.Add(objtbldepartment); ;
            staffContext.SaveChanges();
            return objtbldepartment;
        }

        [HttpPost("UpdateDepartment")]
        public tbldepartment UpdateDepartment(tbldepartment objtbldepartment)
        {
            staffContext.tbldepartment.Update(objtbldepartment);
            staffContext.SaveChanges();
            return objtbldepartment ;
        }

        [HttpDelete("DeleteDepartment/{id}")]
        public ApiResponse<Boolean> DeleteDepartment(int id)
        {
            try
            {
                tbldepartment tbl = GetDepartmentByID(id);

                ApiResponse<Boolean> result = new ApiResponse<Boolean>();
                result.Data = false;

                if (tbl == null)
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = "Department does not exist";
                }
                else if (tbl.IsActive == false)
                {
                    result.IsSuccessfull = false;
                    result.ErrorMessage = "Department already deleted";
                }
                else
                {

                    tbl.IsActive = false;
                    UpdateDepartment(tbl);
                    result.IsSuccessfull = true;
                    result.ErrorMessage = "Department Successfully Deleted";
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
    }
}
