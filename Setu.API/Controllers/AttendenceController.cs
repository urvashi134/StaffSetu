using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.Entities;
using Setu.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendenceController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        public AttendenceController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }
        [HttpPost("GetAttendenceByStaffIdDate")]
        public tblAttendence GetAttendenceByStaffIdDate(AttendenceRules obj)
        {
            return staffContext.tblAttendence.FirstOrDefault(x => x.StaffID == obj.staffId && x.myDate == obj.date);
        }
        [HttpPost("InsertAttendence")]
        public tblAttendence InsertAttendence(tblAttendence objtblAttendence)
        {
            staffContext.tblAttendence.Add(objtblAttendence);
            staffContext.SaveChanges();
            return objtblAttendence;
        }
        [HttpPost("UpdateAttendence")]
        public tblAttendence UpdateAttendence(tblAttendence objtblAttendence)
        {
            staffContext.tblAttendence.Update(objtblAttendence);
            staffContext.SaveChanges();
            return objtblAttendence;
        }
    }
}
