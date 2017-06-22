using Sales.Models;

namespace Sales.Repositories.Sales.Dapper
{
    public class SaleRepository : RepositoryDapper<Sale>, ISaleRepository
    {
        public SaleRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
