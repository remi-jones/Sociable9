using System.ComponentModel.DataAnnotations;

namespace Sociable9.Models
{
    public class Contact
    {
        public int ContactID { get; set; } // PK
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        [StringLength(256)]
        public string? Username { get; set; }

        public Category? Category { get; set; } // Navigation property to Category
    }
}
