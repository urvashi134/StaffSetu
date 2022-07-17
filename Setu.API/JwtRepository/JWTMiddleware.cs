using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Setu.API.Models;
using Setu.Common.DTO;
using System;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Setu.API.JwtRepository
{
    public class JWTMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration configuration;

        // Dependency Injection
        public JWTMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            this.configuration = configuration;
        }

        public async Task Invoke(HttpContext context, UserContext userContext)
        {
                var token = context.Request.Headers[Constants.HEADER_AUTHORISATION].FirstOrDefault()?.Split(" ").Last();

                if (token != null)
                {
                    try
                    {
                        var tokenHandler = new JwtSecurityTokenHandler();
                        var key = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
                        tokenHandler.ValidateToken(token, new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(key),
                            ValidateIssuer = false,
                            ValidateAudience = false,
                            // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                            ClockSkew = TimeSpan.Zero
                        }, out SecurityToken validatedToken);

                        var jwtToken = (JwtSecurityToken)validatedToken;

                        // attach account to context on successful jwt validation
                        //context.Items["Account"] = await dataContext.Accounts.FindAsync(accountId);

                        // UserContext userContext = new UserContext();
                        var id = jwtToken.Claims.First(c => c.Type == Constants.CLAIM_ID).Value;
                        userContext.Id = int.Parse(id, (IFormatProvider)CultureInfo.CurrentCulture);
                        userContext.Email = jwtToken.Claims.First(c => c.Type == Constants.CLAIM_EMAIL).Value;
                        userContext.Role = jwtToken.Claims.First(c => c.Type == Constants.CLAIM_ROLE).Value;
                        userContext.Role = jwtToken.Claims.FirstOrDefault(c => c.Type == Constants.CLAIM_ROLE).Value;
                        var deptId = jwtToken.Claims.First(c => c.Type == Constants.CLAIM_DEPTID).Value;
                        userContext.DepartmentID = int.Parse(deptId, (IFormatProvider)CultureInfo.CurrentCulture);
                        var desgId = jwtToken.Claims.First(c => c.Type == Constants.CLAIM_DESGID).Value;
                        userContext.DesignationID = int.Parse(desgId, (IFormatProvider)CultureInfo.CurrentCulture);
                    }
                    catch (Exception e)
                    {
                        // do nothing if jwt validation fails
                        // account is not attached to context so request won't have access to secure routes
                    }
                }

                await _next(context);
            
            
        }

        /*private async Task attachAccountToContext(HttpContext context, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;

                // attach account to context on successful jwt validation
                //context.Items["Account"] = await dataContext.Accounts.FindAsync(accountId);

                UserContext userContext = new UserContext();
                userContext.Email = jwtToken.Claims.First(c => c.Type == ClaimTypes.Email).Value;
                userContext.Role = jwtToken.Claims.First(c => c.Type == ClaimTypes.Role).Value;
                var val = jwtToken.Claims.First(c => c.Type == "DeptId").Value;
                userContext.DepartmentID = int.Parse(val, (IFormatProvider)CultureInfo.CurrentCulture);
            }
            catch
            {
                // do nothing if jwt validation fails
                // account is not attached to context so request won't have access to secure routes
            }
        }
        */

        /*public async Task Invoke(HttpContext context)
        {
            //context.Request.Path
            if(!(context.Request.Path == "/api/Authentication/authenticate"))
            {
                string authHeader = context.Request.Headers["Authorization"];

                if (authHeader != null)
                {
                    string[] tokenString = authHeader.Split(" ");
                    var token = tokenString[1];
                    var handler = new JwtSecurityTokenHandler();
                    var jwtSecurityToken = handler.ReadJwtToken(token);

                    UserContext userContext = new UserContext();
                    userContext.Email = jwtSecurityToken.Claims.First(c => c.Type == ClaimTypes.Email).Value;
                    userContext.Role = jwtSecurityToken.Claims.First(c => c.Type == ClaimTypes.Role).Value;
                    var val = jwtSecurityToken.Claims.First(c => c.Type == "DeptId").Value;
                    userContext.DepartmentID = int.Parse(val, (IFormatProvider)CultureInfo.CurrentCulture);
                }
            }
                //Pass to the next middleware
                await _next(context);
        } */


    }
}
