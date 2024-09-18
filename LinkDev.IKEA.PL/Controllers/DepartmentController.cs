using LinkDev.IKEA.BLL.Services.DepartmentServices;
using Microsoft.AspNetCore.Mvc;

namespace LinkDev.IKEA.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _departmentservices;

        public DepartmentController(IDepartmentServices departmentservices) 
        {
           _departmentservices = departmentservices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentservices.GetAllDepartment();
            return View(departments);
        }
    }
}
