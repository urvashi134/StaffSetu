using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Setu.API.Models
{
    public class UserContext
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int DepartmentID { get; set; }
        public int DesignationID { get; set; }
    }
}
