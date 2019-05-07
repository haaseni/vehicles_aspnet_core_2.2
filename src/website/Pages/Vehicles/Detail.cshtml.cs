using Microsoft.AspNetCore.Mvc.RazorPages;
using website.Areas.Api.Controllers;
using website.Data;
using website.Enums;
using website.Pages.Classes;

namespace website.Pages.Vehicles
{
    public class DetailModel : PageModel
    {
        private readonly TestContext _context;

        public DetailModel(TestContext context)
        {
            _context = context;
        }

        public int VehicleId { get; set; }
        
        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }
        
        public string Vin { get; set; }
        
        public string Description { get; set; }

        public PageMessage Message { get; set; }

        public void OnGet(int id, string msg)
        {
            var vehicle = new VehiclesController(_context).Get(id);
            
            if (vehicle != null)
            {
                VehicleId = vehicle.VehicleId;
                Make = vehicle.Model.Make.Name;
                Model = vehicle.Model.Name;
                Year = vehicle.Year?.ToString();
                Vin = vehicle.Vin;
                Description = vehicle.Description;
            }

            if (msg == "saved")
            {
                Message = new PageMessage(MessageType.Success, "Vehicle successfully saved");
            }
        }
    }
}