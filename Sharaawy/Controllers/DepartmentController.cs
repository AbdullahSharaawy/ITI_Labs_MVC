using Microsoft.AspNetCore.Mvc;
using Sharaawy_BL.ImplementServices;
using Sharaawy_BL.Services;
namespace Sharaawy.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _DS;

        public DepartmentController(IDepartmentService dS)
        {
            _DS = dS;
        }

        public IActionResult Index()
        {
            return View("Index",_DS.ViewDepartments());
        }
    }
}
