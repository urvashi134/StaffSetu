using System.ComponentModel.DataAnnotations.Schema;

namespace Setu.Entities
{
    [Table("state")]
    public class tblState
    {
        public int ID { get; set; }
        public string StateName { get; set; }
    }
}
