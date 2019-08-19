using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using website.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace website.Areas.Api.v1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly TestContext _context;

        public ModelsController(TestContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var models = await _context.Models
                .Include(m => m.Years)
                .FirstOrDefaultAsync(m => m.ModelId == id);

            return Ok(models);
        }

        [HttpGet("{id:int}/years")]
        public async Task<IActionResult> Years(int id)
        {
            var models = await _context.Models
                .Include(m => m.Years)
                .FirstOrDefaultAsync(m => m.ModelId == id);

            var years = models.Years
                .Select(m => m.Year)
                .ToList();

            return Ok(years);
        }
    }
}
