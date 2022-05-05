using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {
        StaffContext staffContext { get; set; }

        public DesignationController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }

        [HttpGet("GetDesignation")]
        public IList<tblDesignation> GetDesignation()
        {
            return (staffContext.tblDesignation.ToList());
        }
        [HttpPost("InsertDesignation")]
        public tblDesignation InsertDesignation(tblDesignation objtbldesignation)
        {
            staffContext.tblDesignation.Add(objtbldesignation); ;
            staffContext.SaveChanges();
            return objtbldesignation;
        }
    }
}
