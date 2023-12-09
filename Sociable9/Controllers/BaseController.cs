using Microsoft.AspNetCore.Mvc;
using Sociable9.Data;
using Sociable9.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Elfie.Serialization;

namespace Sociable9.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ApplicationDbContext _context;

        public BaseController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected async Task<PaginatedList<Contact>> GetContacts(string sortOrder, string searchString, int? pageNumber, int? pageSize, string username)
        {
            var contactsQuery = _context.Contact.AsQueryable();

            // return all contacts if admin
            if (User.IsInRole("Admin"))
            {
                contactsQuery = contactsQuery.Include(c => c.Category);
                ViewData["count"] = await contactsQuery.CountAsync();
            }
            // Apply user-specific filter if not admin
            else
            {
                contactsQuery = contactsQuery.Include(c => c.Category).Where(c => c.Username == username);
                ViewData["count"] = await contactsQuery.CountAsync();
            }

            // Apply search filter
            if (!String.IsNullOrEmpty(searchString))
            {
                var searchTerms = searchString.Split(' ');

                foreach (var term in searchTerms)
                {
                    contactsQuery = contactsQuery.Where(c => c.FirstName.Contains(term)
                                                          || c.LastName.Contains(term)
                                                          || c.Address.Contains(term)
                                                          || c.Town.Contains(term)
                                                          || c.Province.Contains(term)
                                                          || c.PostalCode.Contains(term)
                                                          || c.PhoneNumber.Contains(term)
                                                          || c.Email.Contains(term)
                                                          // || c.CreationDate.Contains(term) // not practical
                                                          || c.Category.Name.Contains(term)
                                                          );
                }
            }

            switch (sortOrder)
            {
                case "First name ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.FirstName);
                    break;
                case "First name descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.FirstName);
                    break;
                case "Last name ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.LastName);
                    break;
                case "Last name descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.LastName);
                    break;

                case "Address ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.Address);
                    break;
                case "Address descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Address);
                    break;
                case "Town ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.Town);
                    break;
                case "Town descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Town);
                    break;

                case "Province ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.Province);
                    break;
                case "Province descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Province);
                    break;
                case "Postal code ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.PostalCode);
                    break;
                case "Postal code descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.PostalCode);
                    break;
                case "Phone number ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.PhoneNumber);
                    break;
                case "Phone number descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.PhoneNumber);
                    break;
                case "Email ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.Email);
                    break;
                case "Email descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Email);
                    break;               
                case "Creation date ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.CreationDate);
                    break;
                case "Creation date descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.CreationDate);
                    break;
                case "Username ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.Username);
                    break;
                case "Username descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Username);
                    break;                
                case "Category ascending":
                    contactsQuery = contactsQuery.OrderBy(c => c.Category.Name);
                    break;
                case "Category descending":
                    contactsQuery = contactsQuery.OrderByDescending(c => c.Category.Name);
                    break;
                default:
                    contactsQuery = contactsQuery.OrderBy(c => c.ContactID); // Default sorting
                    break;
            }

            // Apply pagination
            int actualPageSize = pageSize ?? 5;
            int actualPageNumber = pageNumber ?? 1;

            ViewData["CurrentPageSize"] = actualPageSize;

            

            ViewData["CurrentFilter"] = searchString;


            return await PaginatedList<Contact>.CreateAsync(contactsQuery.AsNoTracking(), actualPageNumber, actualPageSize);
        }
    }
}
