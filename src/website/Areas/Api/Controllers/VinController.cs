using Vehicles.Web.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Vehicles.Web.Areas.Api.Controllers
{
    [Route("api/[controller]")]
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
