using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class VehicleModel
    {
        public int VehicleId { get; set; }

        public int? MakeId { get; set; }

        public string MakeName { get; set; }

        public int? ModelId { get; set; }

        public string ModelName { get; set; }

        public int? Year { get; set; }

        [StringLength(17)]
        public string Vin { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }
    }
}
