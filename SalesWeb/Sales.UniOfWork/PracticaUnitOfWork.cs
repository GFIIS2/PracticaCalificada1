using Sales.Repositories.Sales.Dapper;
using Sales.Repositories.Sales;

namespace Sales.UnitOfWork
{
    public class PracticaUnitOfWork: IUnitOfWork
    {
        public PracticaUnitOfWork(string connectionString)
        {
            Customers = new CustomerRepository(connectionString);
            Products = new ProductRepository(connectionString);
            Employees = new EmployeeRepository(connectionString);
            Sales = new SaleRepository(connectionString);                 
        }

        public ICustomerRepository Customers { get; private set; }
        public IProductRepository Products { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public ISaleRepository Sales { get; private set; }
     
    }
}
