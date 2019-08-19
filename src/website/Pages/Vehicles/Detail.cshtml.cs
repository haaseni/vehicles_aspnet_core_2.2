using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using website.Areas.Api.v1.Controllers;
using website.Data;
using website.Enums;
using website.Pages.Classes;

namespace website.Pages.Vehicles
{
    public class DetailModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly LinkGenerator _linkGenerator;
        private readonly TestContext _context;

        public DetailModel(TestContext context, LinkGenerator linkGenerator, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _linkGenerator = linkGenerator;
            _httpContextAccessor = httpContextAccessor;
        }

        public int VehicleId { get; set; }
        
        public PageMessage Message { get; set; }

        public void OnGet(int id, string msg)
        {
            VehicleId = id;

            if (msg == "saved")
            {
                Message = new PageMessage(MessageType.Success, "Vehicle successfully saved");
            }
        }
    }
}