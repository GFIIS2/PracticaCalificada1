using Sales.Models;
using Dapper;
using System.Data.SqlClient;

namespace Sales.Repositories.Sales.Dapper
{
    public class EmployeeRepository : RepositoryDapper<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }

        public Employee SearchByLastName(string lastName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@lastName", lastName);

                return connection.QueryFirst<Employee>("dbo.Prod_SearchByNames",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
