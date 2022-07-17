using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Setu.API.JwtRepository
{
    public class JWTManager : IJWTManager
    {
        private readonly IConfiguration configuration;
        public JWTManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public TokenResponse Authenticate(tblStaff user)
        {
            var tokenString = GenerateJwtToken(user);
            TokenResponse tokenResponse = new TokenResponse();
            tokenResponse.Token = tokenString;
            tokenResponse.Id = user.ID;
            tokenResponse.Role = user.Role;
            tokenResponse.UserName = user.StaffName;


            return tokenResponse;
            //throw new System.NotImplementedException();
        }
        private string GenerateJwtToken(tblStaff user)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
            var SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature);

           /* var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.EmailID),
                new Claim(ClaimTypes.Role,user.Role),
                new Claim("DeptId",user.DepartmentID.ToString())
            };*/

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new[]{
                        new Claim(Constants.CLAIM_ID,user.ID.ToString()),
                        new Claim(Constants.CLAIM_EMAIL, user.EmailID),
                        new Claim(Constants.CLAIM_ROLE,user.Role),
                        new Claim(Constants.CLAIM_DEPTID,user.DepartmentID.ToString()),
                        new Claim(Constants.CLAIM_DESGID,user.DesignationID.ToString())
                    }
                ),              
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = SigningCredentials
            };

            var token = tokenhandler.CreateToken(tokenDescriptor);
            return tokenhandler.WriteToken(token);
        }


    }
}
