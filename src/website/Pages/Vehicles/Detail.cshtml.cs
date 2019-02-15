using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Vehicles.Web.Data;
using Vehicles.Web.Entities;
using Vehicles.Web.Enums;
using Vehicles.Web.Pages.Classes;

namespace Vehicles.Web.Pages.Vehicles
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
            var vehicle = _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .FirstOrDefault(v => v.VehicleId == id);
            
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