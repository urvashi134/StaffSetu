
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private StaffContext staffContext { get; set; }
        public CommonController(StaffContext staffContext)
        {
            this.staffContext = staffContext;
        }
        [HttpGet("GetYearMonthForConfirmAttendance")]
        public List<YearMonthDTO> GetYearMonthForConfirmAttendance()
        {
            List<YearMonthDTO> yearMonthDTO = new List<YearMonthDTO>();
            var data= staffContext.tblAttendence.Select(x => x.myDate).Distinct().ToList();
            foreach(DateTime date in data )
            {
                if(yearMonthDTO.Any(x => x.Year == date.Year))
                {
                    var val = yearMonthDTO.FirstOrDefault(x => x.Year == date.Year);
                    if(!val.Months.Any(x => x == date.Month))
                    {
                        val.Months.Add(date.Month);
                    }
                }
                else
                {
                    yearMonthDTO.Add(new YearMonthDTO()
                    {
                        Year = date.Year,
                        Months = new List<int>()
                        {
                            date.Month
                        }
                    });
                }
            }
            return yearMonthDTO;

        }
    }
}
