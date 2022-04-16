using System.ComponentModel.DataAnnotations.Schema;

namespace Setu.Entities
{
    [Table("designation")]
    public class tblDesignation
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
