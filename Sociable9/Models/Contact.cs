namespace Sociable9.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime CreationDate { get; set; }
        public int CategoryID { get; set; }
        public string? Username { get; set; }

        public Category? Category { get; set; } // Navigation property to Category
    }
}
