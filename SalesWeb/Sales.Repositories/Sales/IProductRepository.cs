using Sales.Models;

namespace Sales.Repositories.Sales
{
    public interface IProductRepository : IRepository<Product>
    {
        Product SearchByName(string productName);
    }
}
