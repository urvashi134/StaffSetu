using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Setu.API.Models;
using Setu.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendenceRulesController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        public AttendenceRulesController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }
        [HttpGet("GetAttendenceRules")]
        public IList<tblAttendenceRules> GetAttendenceRules()
        {
            return staffContext.tblAttendenceRule.Include(x=>x.designation).ToList();
        }
        [HttpGet("GetAttendenceRulesByDesg")]
        public tblAttendenceRules GetAttendenceRulesByDesg(int desgId)
        {
            return staffContext.tblAttendenceRule.FirstOrDefault(x => x.DesgId == desgId);
        }

        [HttpPost("InsertAttendenceRules")]
        public tblAttendenceRules InsertAttendenceRules(tblAttendenceRules objtblAttendenceRules)
        {
            staffContext.tblAttendenceRule.Add(objtblAttendenceRules);
            staffContext.SaveChanges();
            return objtblAttendenceRules;
        }
        [HttpPost("UpdateAttendenceRules")]
        public tblAttendenceRules UpdateAttendenceRules(tblAttendenceRules objtblAttendenceRules)
        {
            staffContext.tblAttendenceRule.Update(objtblAttendenceRules);
            staffContext.SaveChanges();
            return objtblAttendenceRules;
        }
    }
}
