using System.Collections.Generic;
using System.Linq;
using Vehicles.Web.Data;
using Vehicles.Web.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Vehicles.Web.Areas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly TestContext _context;

        public ModelsController(TestContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public Model Get(int id)
        {
            return _context.Models
                .Include(m => m.Years)
                .FirstOrDefault(m => m.ModelId == id);
        }

        [HttpGet("{id:int}/years")]
        public List<int> Years(int id)
        {
            return _context.Models
                .Include(m => m.Years)
                .FirstOrDefault(m => m.ModelId == id)?
                .Years
                .Select(m => m.Year)
                .ToList();
        }
    }
}
