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
            return staffContext.tblSubject.ToList();
        }
        [HttpGet("GetSubjectByDepartmentID/{id}")]
        public IList<tblSubject> GetSubjectByDepartmentID(int id)
        {
            return staffContext.tblSubject.Where(x=> x.DeptID == id).ToList();  

        }
        [HttpPost("InsertSubject")]
        public tblSubject InsertSubject(tblSubject objtblSubject)
        {
            staffContext.tblSubject.Add(objtblSubject);
            staffContext.SaveChanges();
            return objtblSubject;
        }
    }
}
