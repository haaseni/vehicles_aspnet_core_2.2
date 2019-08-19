using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using website.Areas.Api.v1.Controllers;
using website.Data;
using website.Entities;
using website.Enums;
using website.Pages.Classes;

namespace website.Pages.Vehicles
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class EditModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly LinkGenerator _linkGenerator;
        private readonly TestContext _context;

        public EditModel(TestContext context, LinkGenerator linkGenerator, IHttpContextAccessor httpContextAccessor)
        {
            Makes = new List<Make>();
            Models = new List<Model>();
            Years = new List<ModelYear>();

            _context = context;
            _linkGenerator = linkGenerator;
            _httpContextAccessor = httpContextAccessor;
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
            VehicleId = id;
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Initialize();

            if (!ModelState.IsValid)
                return Page();

            try
            {
                var vehicle = new Vehicle
                {
                    ModelId = Convert.ToInt32(Model),
                    Year = Convert.ToInt32(Year),
                    Vin = Vin,
                    Description = Description
                };

                if (id == 0)
                {
                    var result = await new VehiclesController(_context, _linkGenerator, _httpContextAccessor).Post(vehicle);
                    
                    if (result is CreatedResult createdResult)
                        return Redirect(createdResult.Location);

                    if(result is ObjectResult objectResult && objectResult.Value is Exception exception)
                        throw exception;
                }
                else
                {
                    await new VehiclesController(_context, _linkGenerator, _httpContextAccessor).Put(id, vehicle);
                    return RedirectToPage("detail", new { id = id, msg = "saved" });
                }
            }
            catch (Exception e)
            {
                Message = new PageMessage(MessageType.Error, $"Error saving vehicle");
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