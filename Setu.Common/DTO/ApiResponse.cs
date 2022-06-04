using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class ApiResponse<T>
    {
        public bool IsSuccessfull { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}
