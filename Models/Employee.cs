using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email address")]
        [Length(5, 50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [MaxLength(30)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [MaxLength(50)]
        public string Position { get; set; }
    }
}
