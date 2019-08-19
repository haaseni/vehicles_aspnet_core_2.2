using website.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace website.Areas.Api.v1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]    
    public class VinController : ControllerBase
    {
        private readonly TestContext _context;

        public VinController(TestContext context)
        {
            _context = context;
        }

        [HttpGet, HttpPost]
        [Route("verify")]
        public IActionResult Verify(string vin)
        {
            if (_context.Vins.Any(m => m.VehicleIdentificationNumber == vin))
                return Ok(false);

            return Ok(true);
        }
    }
}
