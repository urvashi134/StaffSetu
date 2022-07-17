using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.JwtRepository;
using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        StaffContext staffContext { get; set; }

        private readonly IJWTManager jWTManager;
        public AuthenticationController(StaffContext staffContext, IJWTManager jWTManager)
        {
            this.staffContext = staffContext;
            this.jWTManager = jWTManager;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public TokenResponse Authenticate(TokenRequest user)
        {
            var token = new TokenResponse();
            if (user.Email == null || user.Password == null)
            {
                token = null;
            }
            else
            {
                tblStaff staff = GetStaffByEmailPassword(user.Email, user.Password);

                if (staff == null)
                {
                    token = null;
                }
                else
                {
                    token = jWTManager.Authenticate(staff);
                }
            }
            return token;
        }


        /*public IActionResult Authenticate(TokenRequest user)
        {
            var token = new TokenResponse();
            if (user.Email == null || user.Password == null)
            {
                token = null;
            }
            else
            {
                tblStaff staff = GetStaffByEmailPassword(user.Email, user.Password);

                if (staff == null)
                {
                    token = null;
                }
                else
                {
                    token = jWTManager.Authenticate(staff);
                }
            }

            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        */

        private tblStaff GetStaffByEmailPassword(string email, string password)
        {
            var response =  staffContext.tblStaff.FirstOrDefault(x => x.EmailID == email && x.Password == password);
            return response;
        }
    }
}
