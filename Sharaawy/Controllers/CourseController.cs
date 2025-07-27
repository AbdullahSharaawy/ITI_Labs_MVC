using Microsoft.AspNetCore.Mvc;

namespace Sharaawy.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
