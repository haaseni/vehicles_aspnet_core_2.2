using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.Web.Data;
using Vehicles.Web.Entities;
using Vehicles.Web.Enums;
using Vehicles.Web.Pages.Classes;

namespace Vehicles.Web.Pages.Vehicles
{
    public class EditModel : PageModel
    {
        private readonly TestContext _context;

        public EditModel(TestContext context)
        {
            Makes = new List<Make>();
            Models = new List<Model>();
            Years = new List<ModelYear>();

            _context = context;
        }

        public int VehicleId { get; set; }

        [Required]
        [BindProperty]
        public string Make { get; set; }

        [Required]
        [BindProperty]
        public string Model { get; set; }

        [Required]
        [BindProperty]
        public string Year { get; set; }

        [Required]
        [StringLength(17)]
        [BindProperty]
        [Remote(action: "Verify", controller: "Vin", ErrorMessage = "VIN matches a stolen vehicle!")]
        public string Vin { get; set; }

        [StringLength(4000)]
        [BindProperty]
        public string Description { get; set; }

        public List<Make> Makes { get; set; }

        public List<Model> Models { get; set; }

        public List<ModelYear> Years { get; set; }
        
        public PageMessage Message { get; set; }
        
        public void OnGet(int id)
        {
            var vehicle = _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .FirstOrDefault(v => v.VehicleId == id);
            
            if (vehicle != null)
            {
                VehicleId = vehicle.VehicleId;
                Make = vehicle.Model.Make.MakeId.ToString() ?? string.Empty;
                Model = vehicle.Model.ModelId.ToString() ?? string.Empty;
                Year = vehicle.Year.ToString() ?? string.Empty;
                Vin = vehicle.Vin;
                Description = vehicle.Description;
            }

            Initialize();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Initialize();

            if (!ModelState.IsValid)
                return Page();

            try
            {
                var vehicle = _context.Vehicles
                                  .Include(m => m.Model)
                                  .FirstOrDefault(m => m.VehicleId == id) ?? new Vehicle();

                vehicle.ModelId = Convert.ToInt32(Model);
                vehicle.Year = Convert.ToInt32(Year);
                vehicle.Vin = Vin;
                vehicle.Description = Description;

                if (vehicle.VehicleId == 0)
                    _context.Vehicles.Add(vehicle);

                await _context.SaveChangesAsync();
                return RedirectToPage("Detail", new { id = vehicle.VehicleId, msg = "saved" });
            }
            catch (Exception e)
            {
                Message = new PageMessage(MessageType.Error, "Error saving vehicle");
            }

            return Page();
        }

        private void Initialize()
        {
            Makes = _context.Makes
                .OrderBy(m => m.Name)
                .ToList();

            if (!string.IsNullOrWhiteSpace(Make))
            {
                Models = _context.Models
                    .Where(m => m.MakeId == int.Parse(Make))
                    .OrderBy(m => m.Name)
                    .ToList();
            }

            if (!string.IsNullOrWhiteSpace(Model))
            {
                Years = _context.ModelYears
                    .Where(m => m.ModelId == int.Parse(Model))
                    .OrderBy(y => y.Year)
                    .ToList();
            }
        }
    }
}