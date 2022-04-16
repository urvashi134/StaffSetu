using System.ComponentModel.DataAnnotations.Schema;

namespace Setu.API.Models
{
    [Table("city")]
    public class tblCity
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public int StateID{ get; set; }
    }
}
