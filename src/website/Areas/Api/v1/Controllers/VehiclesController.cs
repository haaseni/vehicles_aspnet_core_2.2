using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using website.Data;
using website.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using website.Models;

namespace website.Areas.Api.v1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly LinkGenerator _linkGenerator;
        private readonly TestContext _context;

        public VehiclesController(TestContext context, LinkGenerator linkGenerator, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _linkGenerator = linkGenerator;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var vehicles = await _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .ToListAsync();

            var model = new VehiclesModel();

            vehicles.ForEach(v => model.Vehicles.Add(new VehicleModel
            {
                VehicleId = v.VehicleId,
                MakeId = v.Model.MakeId,
                MakeName = v.Model.Make.Name,
                ModelId = v.ModelId,
                ModelName = v.Model.Name,
                Description = v.Description,
                Year = v.Year,
                Vin = v.Vin
            }));

            return Ok(model);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var vehicle = await _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            var model = new VehicleModel
            {
                VehicleId = vehicle.VehicleId,
                MakeId = vehicle.Model.MakeId,
                MakeName = vehicle.Model.Make.Name,
                ModelId = vehicle.ModelId,
                ModelName = vehicle.Model.Name,
                Description = vehicle.Description,
                Year = vehicle.Year,
                Vin = vehicle.Vin
            };

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Vehicle model)
        {
            try
            {
                var vehicle = new Vehicle
                {
                    ModelId = model.ModelId,
                    Year = model.Year,
                    Vin = model.Vin,
                    Description = model.Description
                };
                
                _context.Vehicles.Add(vehicle);

                await _context.SaveChangesAsync();

                var link = _linkGenerator.GetUriByPage(_httpContextAccessor.HttpContext, "/vehicles/detail", null, new {id = vehicle.VehicleId, msg = "saved"});

                return Created(link, vehicle);
            }
            catch (Exception e)
            {
                return StatusCode(500, e); // TODO: Log error then just return a 500 error
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody]Vehicle model)
        {
            try
            {
                var vehicle = await _context.Vehicles.FindAsync(id);

                if (vehicle == null)
                    return BadRequest("Vehicle to update was not found");
                
                vehicle.ModelId = model.ModelId;
                vehicle.Year = model.Year;
                vehicle.Vin = model.Vin;
                vehicle.Description = model.Description;
                
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e); // TODO: Log error then just return a 500 error
            }
        }
    }
}
