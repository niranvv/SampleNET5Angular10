using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FallbackController : Controller //Not APIController
    {
        // Fix error with refreshing the page which ends is page not found 
        public ActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
    }
}