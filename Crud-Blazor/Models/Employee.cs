using System.ComponentModel.DataAnnotations;

namespace Crud_Blazor.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName 是必填")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName 是必填")]
        public string LastName { get; set; }
    }
}