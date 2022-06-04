using System;
using System.Collections.Generic;
using System.Text;

namespace Setu.Common.DTO
{
    public class AddBeneficiaryRequestDTO
    {
        public string beneId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string bankAccount { get; set; }
        public string ifsc { get; set; }
        public string vpa { get; set; }
        public string cardNo { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }
    }
}
