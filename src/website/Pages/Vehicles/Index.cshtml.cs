using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using website.Data;
using website.Entities;

namespace website.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        private readonly TestContext _context;
        
        public IndexModel(TestContext context)
        {
            _context = context;
        }

        public List<Vehicle> Vehicles { get; set; }

        public void OnGet()
        {
            DbInitializer.Initialize(_context); // Initialize data in database if blank
            
            Vehicles = _context.Vehicles
                .Include(m => m.Model)
                .Include(m => m.Model.Make)
                .ToList();
        }
    }
}