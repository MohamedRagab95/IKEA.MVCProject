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


        public IActionResult Index()
        {
            return View();
        }
    }
}
