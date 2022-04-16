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
    public class StateController : ControllerBase
    {
        StaffContext staffContext { get; set; }

        public StateController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }

        [HttpGet("GetState")]
        public IList<tblState> GetState()
        {
            return (staffContext.tblState.ToList());
        }
        
    }
}
