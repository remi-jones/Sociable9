using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sociable9.Models;

namespace Sociable9.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sociable9.Models.Category> Category { get; set; } = default!;
        public DbSet<Sociable9.Models.Contact> Contact { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Family" },
                new Category { CategoryID = 2, Name = "Friend" },
                new Category { CategoryID = 3, Name = "Work" },
                new Category { CategoryID = 4, Name = "Other" }
            );

            // Seed Contacts
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "1234 Street",
                    Town = "Townsville",
                    Province = "Province",
                    PostalCode = "12345",
                    PhoneNumber = "123-456-7890",
                    Email = "john.doe@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 1,  // Assuming this is the ID for "Family"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jane.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 3,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 4,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 5,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 6,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 7,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 8,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 9,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 10,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 11,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "11contacts" // Assuming this is a valid username in your system
                },
                new Contact
                {
                    ContactID = 12,
                    FirstName = "Jenny",
                    LastName = "Smith",
                    Address = "5678 Avenue",
                    Town = "Citytown",
                    Province = "Province",
                    PostalCode = "54321",
                    PhoneNumber = "098-765-4321",
                    Email = "jenny.smith@example.com",
                    CreationDate = DateTime.Now,
                    CategoryID = 2,  // Assuming this is the ID for "Friend"
                    Username = "1contact" // Assuming this is a valid username in your system
                }
            );

            // Example: Configuring a one-to-many relationship between Category and Contact
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Contacts)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryID);

            // Any additional model configuration...
        }
    }
}
