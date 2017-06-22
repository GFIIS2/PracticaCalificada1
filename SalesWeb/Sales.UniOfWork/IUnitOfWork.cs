using Sales.Repositories.Sales;

namespace Sales.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }
        IEmployeeRepository Employees { get; }

        ISaleRepository Sales { get; }
    }
}
