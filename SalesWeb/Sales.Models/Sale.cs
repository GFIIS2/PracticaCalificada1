namespace Sales.Models
{
    public class Sale
    {
        public int SalesID { get; set; }
        public int SalesPersonID { get; set; }
        public int CustomerID { get; set; }        
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
