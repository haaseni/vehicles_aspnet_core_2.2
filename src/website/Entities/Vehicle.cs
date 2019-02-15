using System.ComponentModel.DataAnnotations;

namespace Vehicles.Web.Entities
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public int? ModelId { get; set; }

        public int? Year { get; set; }

        [StringLength(17)]
        public string Vin { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }
        
        public virtual Model Model { get; set; }
    }
}
