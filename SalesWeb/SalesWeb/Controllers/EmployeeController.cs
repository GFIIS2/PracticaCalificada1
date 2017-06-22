using Sales.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Sales.UnitOfWork;

namespace Sales.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unit;

        public EmployeeController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Employees.GetAll());
        }
        public IActionResult Detail()
        {
            var customers = _unit.Employees.SearchByLastName("Bennet");
            return View(customers);
        }
    }
}