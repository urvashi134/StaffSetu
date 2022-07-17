using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string RefreshToken { get; set; }
    }
}
