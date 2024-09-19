using LinkDev.IKEA.BLL.CustomModels.DepartmentDTO;
using LinkDev.IKEA.BLL.Services.DepartmentServices;
using LinkDev.IKEA.DAL.Enteties.Department;
using Microsoft.AspNetCore.Mvc;

namespace LinkDev.IKEA.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentServices _departmentservices;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IWebHostEnvironment _environment;

        public DepartmentController(
            IDepartmentServices departmentservices,
            ILogger<DepartmentController> logger,
            IWebHostEnvironment environment)
        {
            _departmentservices = departmentservices;
            _logger = logger;
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentservices.GetAllDepartment();
            return View(departments);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto createdDepartmentDto)
        {
            if (!ModelState.IsValid)
            {
                return View(createdDepartmentDto);
            }

            var massage = string.Empty;

            try
            {
                var result = _departmentservices.CreateDepartment(createdDepartmentDto);
                if (result > 0)
                    return RedirectToAction(nameof(Index));
                else
                {
                    massage = "Department is not created";
                    ModelState.AddModelError(string.Empty, massage);
                    return View(createdDepartmentDto);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                if (_environment.IsDevelopment())
                {
                    massage = ex.Message;

                    return View(createdDepartmentDto);
                }
                else
                {

                    massage = "Department is not created";
                    return View("Error", massage);

                }


            }

        }



        [HttpGet]
        
        public IActionResult Details(int? id)
        {


            if (id is null)

                return BadRequest();

            var department = _departmentservices.GetDepartmentById(id.Value);

            if (department is null)

                return NotFound();

            return View(department);
        }
    }
}
