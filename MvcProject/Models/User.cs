using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        [Phone]
        public string Phone { get; set; } = "";

        [EmailAddress]
        public string Email { get; set; } = "";
    }
}
