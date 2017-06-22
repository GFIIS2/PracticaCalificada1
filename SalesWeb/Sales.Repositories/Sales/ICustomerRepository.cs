using Sales.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Repositories.Sales
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer SearchByFirstName(string firstName);
    }
}
