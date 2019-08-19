using System.Collections.Generic;

namespace website.Models
{
    public class VehiclesModel
    {
        public VehiclesModel()
        {
            Vehicles = new List<VehicleModel>();
        }

        public List<VehicleModel> Vehicles { get; set; }
    }
}
