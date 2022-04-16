using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Setu.Entities
{   
    [Table("subject")]
    public class tblSubject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int DeptID { get; set; }
    }
}
