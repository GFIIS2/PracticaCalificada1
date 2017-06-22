using Sales.Models;
using Dapper;
using System.Data.SqlClient;

namespace Sales.Repositories.Sales.Dapper
{
    public class ProductRepository : RepositoryDapper<Product>, IProductRepository
    {
        public ProductRepository(string connectionString) : base(connectionString)
        {
        }

        public Product SearchByName(string productName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@productName", productName);

                return connection.QueryFirst<Product>("dbo.Prod_SearchByNames",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
