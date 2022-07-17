using Setu.API.Models;
using Setu.Common.DTO;
using Setu.Entities;

namespace Setu.API.JwtRepository
{
    public interface IJWTManager
    {
        TokenResponse Authenticate(tblStaff user);
    }
}
