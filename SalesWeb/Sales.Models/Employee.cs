using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        //public String MyProperty { get; set; } //es un objeto "String" por eso no es recomendable el uso.

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "this field is required")]
        public string FirstName { get; set; } //es un clase natibo por eso es recomendable el uso.

        [Display(Name = "Middle Initial")]
        [Required(ErrorMessage = "this field is required")]
        public string MiddleInitial { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "this field is required")]
        public string LastName { get; set; }
    }
}
