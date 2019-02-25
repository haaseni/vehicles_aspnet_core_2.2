using System.Collections.Generic;
using System.Linq;
using website.Data;
using website.Entities;
using Microsoft.AspNetCore.Mvc;

namespace website.Areas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MakesController : ControllerBase
    {
        private readonly TestContext _context;

        public MakesController(TestContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public Make Get(int id)
        {
            return _context.Makes
                .FirstOrDefault(m => m.MakeId == id);
        }

        [HttpGet("{id:int}/models")]
        public List<Model> Models(int id)
        {
            return _context.Models
                .Where(m => m.MakeId == id).ToList();
        }
    }
}
