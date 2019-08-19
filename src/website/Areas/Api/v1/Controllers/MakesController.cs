using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website.Data;
using website.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace website.Areas.Api.v1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MakesController : ControllerBase
    {
        private readonly TestContext _context;

        public MakesController(TestContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var makes = await _context.Makes.ToListAsync();

            return Ok(makes);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var make = await _context.Makes.FirstOrDefaultAsync(m => m.MakeId == id);

            return Ok(make);
        }

        [HttpGet("{id:int}/models")]
        public async Task<IActionResult> Models(int id)
        {
            var models = await _context.Models
                .Where(m => m.MakeId == id)
                .ToListAsync();

            return Ok(models);
        }
    }
}
