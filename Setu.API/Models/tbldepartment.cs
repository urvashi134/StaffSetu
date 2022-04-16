using System.ComponentModel.DataAnnotations.Schema;

namespace Setu.API.Models
{
    [Table("department")]
    public class tbldepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
