using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicles.Web.Entities
{
    [Table("ModelYears")]
    public class ModelYear
    {
        public int ModelId { get; set; }
        
        public int Year { get; set; }
    }
}
