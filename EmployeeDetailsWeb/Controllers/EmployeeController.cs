using EmployeeDetails.DataAccess;
using EmployeeDetails.DataModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetailsWeb.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext _context;

        //get dbContext 
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> employees = _context.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee empolyee)
        {
            //Server Side Validation
            //Check model State is valid
            if (ModelState.IsValid)
            {
                _context.Add(empolyee);
                _context.SaveChanges();
                TempData["success"] = "Employee Add Successfully";
                return RedirectToAction("Index");
            }
            return View(empolyee);
        }
    }
}
