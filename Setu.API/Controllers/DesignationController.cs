using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Setu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DesignationController : ControllerBase
    {
        StaffContext staffContext { get; set; }
        UserContext userContext { get; set; }

        public DesignationController(StaffContext staffContext,UserContext userContext)
        {
            this.staffContext = staffContext;
            this.userContext = userContext;
        }
        // For all ??
        [HttpGet("GetDesignation")]
        public ApiResponse<List<tblDesignation>> GetDesignation()
        {
            ApiResponse<List<tblDesignation>> response = new ApiResponse<List<tblDesignation>>();
            response.Data = null;
            

            try
            {
                string role = userContext.Role;
                int desgId = userContext.DesignationID;
                List<tblDesignation> tbl = staffContext.tblDesignation.Where(x=>  !(role==RolesConstant.ROLE_STAFF) || x.ID==desgId).ToList();      
               
                    if (tbl.Count == 0)
                    {
                        response.IsSuccessfull = false;
                        response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_FOUND;
                    }
                    else
                    {
                        response.IsSuccessfull = true;
                        response.Data = tbl;
                    }
                
            }
            catch(Exception)
            {
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
            //return (staffContext.tblDesignation.ToList());
        }
        // Only for master admin ??
        [HttpPost("InsertDesignation")]
        public ApiResponse<tblDesignation> InsertDesignation(tblDesignation objtbldesignation)
        {

            ApiResponse<tblDesignation> response = new ApiResponse<tblDesignation>();
            response.Data = null;
            try
            {
                string role = userContext.Role;
                if(role == RolesConstant.ROLE_ADMIN)
                {
                    staffContext.tblDesignation.Add(objtbldesignation);
                    staffContext.SaveChanges();

                    response.IsSuccessfull = true;
                    response.Data = objtbldesignation;
                }
                else
                {
                    response.IsSuccessfull = false;
                    response.ErrorMessage = ApiResponseConstants.MESSAGE_NOT_ALLOWED;
                }
            }
            catch(Exception)
            {
                //objtbldesignation = null;
                response.IsSuccessfull = false;
                response.ErrorMessage = ApiResponseConstants.MESSAGE_REQUEST_FAILED;
            }
            return response;
        }
    }
}
