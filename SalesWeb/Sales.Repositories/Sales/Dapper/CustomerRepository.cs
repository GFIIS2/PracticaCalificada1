using Sales.Models;
using Dapper;
using System.Data.SqlClient;

namespace Sales.Repositories.Sales.Dapper
{
    public class CustomerRepository : RepositoryDapper<Customer>, ICustomerRepository
    {
        public CustomerRepository(string connectionString) : base(connectionString)
        {

        }

        public Customer SearchByFirstName(string firstName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@firstName", firstName);
                
                return connection.QueryFirst<Customer>("dbo.SearchByNames",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
