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
    public class CityController : ControllerBase
    {
        StaffContext staffContext { get; set; }

        public CityController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }

        [HttpGet("GetCityByStateID/{id}")]
        public IList<tblCity> GetCityByStateID(int id)
        {
            return staffContext.tblCity.Where(x => x.StateID == id).ToList();
        }
    }
}
