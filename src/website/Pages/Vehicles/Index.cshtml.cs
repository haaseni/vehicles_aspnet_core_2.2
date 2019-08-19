using Microsoft.AspNetCore.Mvc.RazorPages;
using website.Data;

namespace website.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        private readonly TestContext _context;
        
        public IndexModel(TestContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            DbInitializer.Initialize(_context); // Initialize data in database if blank
        }
    }
}