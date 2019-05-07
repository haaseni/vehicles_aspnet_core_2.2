using System.Collections.Generic;
using System.Linq;
using website.Data;
using website.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace website.Areas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly TestContext _context;

        public VehiclesController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Vehicle> Get()
        {
            return _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .ToList();
        }

        [HttpGet("{id:int}")]
        public Vehicle Get(int id)
        {
            return _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .FirstOrDefault(v => v.VehicleId == id);
        }
    }
}
