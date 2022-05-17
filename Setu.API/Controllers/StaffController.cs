using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Setu.API.Models;
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
        public StaffController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
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
    }
}
