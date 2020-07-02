using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Milio.API.Controllers
{
	[AllowAnonymous]
    public class Fallback : Controller
	    {
	        public IActionResult Index()
	        {
	            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
	        }
	    }
}