using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "this field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "this field is required")]
        public decimal Price { get; set; }
    }
}
