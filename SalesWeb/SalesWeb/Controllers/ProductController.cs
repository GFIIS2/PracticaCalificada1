using Sales.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Sales.UnitOfWork;

namespace Sales.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unit;

        public ProductController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Products.GetAll());
        }
        public IActionResult Detail()
        {
            var customers = _unit.Products.SearchByName("Blade");
            return View(customers);
        }
    }
}