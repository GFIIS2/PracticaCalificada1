using Sales.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Sales.UnitOfWork;

namespace Sales.Web.Controllers
{
    [ExceptionLoggerFilter]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;
        //private readonly NorthwinddbContext _db;


        //esta variable solo puede ser usada en el contructor y en ningun otro lado.

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
            var customers = _unit.Customers.SearchByFirstName("Maria");
            return View(customers);
        }

    }
}