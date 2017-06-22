using Sales.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Sales.UnitOfWork;

namespace Sales.Web.Controllers
{
    public class SaleController : Controller
    {
        private readonly IUnitOfWork _unit;

        public SaleController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Sales.GetAll());
        }
        
    }
}