using System.ComponentModel.DataAnnotations.Schema;

namespace website.Entities
{
    [Table("ModelYears")]
    public class ModelYear
    {
        public int ModelId { get; set; }
        
        public int Year { get; set; }
    }
}
