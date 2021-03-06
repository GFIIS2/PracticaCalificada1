using Sales.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Sales.UnitOfWork;

namespace Sales.Web.Controllers
{
    [ExceptionLoggerFilter]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;
        
        public CustomerController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Customers.GetAll());
        }
        public IActionResult Detail()
        {
            var customers = _unit.Customers.SearchByFirstName("Aaron");
            return View(customers);
        }

    }
}