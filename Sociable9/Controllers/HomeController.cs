using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sociable9.Data;
using Sociable9.Models;
using System.Diagnostics;

namespace Sociable9.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) : base(context) { }
        public async Task<IActionResult> Index(string sortOrder, string searchString, int? pageNumber, int? pageSize)
        {
            // saving the sort
            ViewBag.CurrentSort = sortOrder;

            // applying the sort based on the option selected
            ViewBag.FirstNameSortParm = sortOrder == "First name ascending" ? "First name descending" : "First name ascending";
            ViewBag.LastNameSortParm = sortOrder == "Last name ascending" ? "Last name descending" : "Last name ascending";
            ViewBag.AddressSortParm = sortOrder == "Address ascending" ? "Address descending" : "Address ascending";
            ViewBag.TownSortParm = sortOrder == "Town ascending" ? "Town descending" : "Town ascending";
            ViewBag.ProvinceSortParm = sortOrder == "Province ascending" ? "Province descending" : "Province ascending";
            ViewBag.PostalCodeSortParm = sortOrder == "Postal code ascending" ? "Postal code descending" : "Postal code ascending";
            ViewBag.PhoneNumberSortParm = sortOrder == "Phone number ascending" ? "Phone number descending" : "Phone number ascending";
            ViewBag.EmailSortParm = sortOrder == "Email ascending" ? "Email descending" : "Email ascending";
            ViewBag.CreationDateSortParm = sortOrder == "Creation date ascending" ? "Creation date descending" : "Creation date ascending";
            ViewBag.UsernameSortParm = sortOrder == "Username ascending" ? "Username descending" : "Username ascending";
            ViewBag.CategorySortParm = sortOrder == "Category ascending" ? "Category descending" : "Category ascending";

            // getting current username
            var username = User.Identity.Name;
            // getting model (GetContacts defined in BaseController)
            var model = await GetContacts(sortOrder, searchString, pageNumber, pageSize, username);
            ViewData["Admin"] = false;
            ViewData["User"] = false;
            if (User.IsInRole("Admin"))
                ViewData["Admin"] = true;
            if (User.Identity.IsAuthenticated)
                ViewData["User"] = true;

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
