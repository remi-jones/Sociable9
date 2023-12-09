namespace Sociable9.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string? Name { get; set; }

        public ICollection<Contact>? Contacts { get; set; } // Navigation property to Contacts
    }
}
