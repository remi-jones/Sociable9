using System.ComponentModel.DataAnnotations;

namespace Sociable9.Models
{
    public class Category
    {
        public int CategoryID { get; set; } // PK
        [Required]
        public string? Name { get; set; }

        public ICollection<Contact>? Contacts { get; set; } // Navigation property to Contacts
    }
}
