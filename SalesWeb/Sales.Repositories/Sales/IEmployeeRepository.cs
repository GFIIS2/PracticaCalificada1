using Sales.Models;

namespace Sales.Repositories.Sales
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee SearchByLastName(string lastName);
    }
}
