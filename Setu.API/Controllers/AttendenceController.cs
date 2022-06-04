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
        [HttpGet("GetAttendenceByStaffIdMonthYear/{obj}")]
        public IList<tblAttendence> GetAttendenceByStaffIdMonthYear(UserAttendenceReport obj)
        {
            return staffContext.tblAttendence.Where(x => x.StaffID == obj.StaffId && x.myDate>=obj.AttendenceFrom && x.myDate<=obj.AttendenceTill).ToList();
        }
        [HttpGet("GetAttendenceByMonthYear/{obj}")]
        public IList<tblAttendence> GetAttendenceByMonthYear(UserAttendenceReport obj)
        {
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
            //int count = val.Count;
            return (IList<tblAttendence>)val;
        }
        [HttpPost("GetAttendenceByStaffIdDate/{obj}")]
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
        [HttpPost("GetAttendenceByDate")]
        public List<AttendenceRegisterResponseDTO> GetAttendenceByDate(AttendenceRules obj)
        {
            List<AttendenceRegisterResponseDTO> attendenceRegisterResponseDTOs = new List<AttendenceRegisterResponseDTO>(); 
            var dayAttendence = staffContext.tblAttendence.Where(x => x.myDate == obj.date);
            foreach (tblStaff staff in staffContext.tblStaff.ToList())
            {
                AttendenceRegisterResponseDTO attendenceRegisterResponseDTO = new AttendenceRegisterResponseDTO
                {
                    StaffID = staff.ID,
                    StaffName = staff.StaffName
                };
                var staffDayAttendence = dayAttendence.FirstOrDefault(x => x.StaffID == staff.ID);
                if(staffDayAttendence != null)
                {
                    attendenceRegisterResponseDTO.Status = staffDayAttendence.Status == 'P' ? "Present": staffDayAttendence.Status == 'A' ? "Absent"  :"Leave";
                    attendenceRegisterResponseDTO.StartTime = staffDayAttendence.StartTime;
                    attendenceRegisterResponseDTO.EndTime = staffDayAttendence.EndTime;
                }
                attendenceRegisterResponseDTOs.Add(attendenceRegisterResponseDTO);
            }
            return attendenceRegisterResponseDTOs;
        }
    }
}
