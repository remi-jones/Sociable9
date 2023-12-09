using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sociable9.Data;
using Sociable9.Models;

namespace Sociable9.Controllers
{
    [Authorize]
    public class ContactsController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context) : base(context) { this._context = context; }

        public async Task<IActionResult> Index(string sortOrder, string searchString, int? pageNumber, int? pageSize)
        {
            ViewBag.CurrentSort = sortOrder;
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

            var username = User.Identity.Name; // Or however you get the current user
            var model = await GetContacts(sortOrder, searchString, pageNumber, pageSize, username);
            ViewData["Admin"] = false;
            ViewData["User"] = false;
            if (User.IsInRole("Admin"))
                ViewData["Admin"] = true;
            if (User.Identity.IsAuthenticated)
                ViewData["User"] = true; 
            return View(model);
        }

        // GET: Contacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.ContactID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: Contacts/Create
        public IActionResult Create()
        {
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "Name");

            // returning admin info so admin can create and specify createdate, username
            ViewData["Admin"] = false;
            if (User.IsInRole("Admin"))
                ViewData["Admin"] = "true";

            return View();
        }


        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactID,FirstName,LastName,Address,Town,Province,PostalCode,PhoneNumber,Email,CreationDate,CategoryID,Username")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                // if user is admin, use data contained in contact
                // ELSE (user not admin), use his username and datetime.now
                if (!User.IsInRole("Admin"))
                {
                    contact.Username = User.Identity.Name;
                    contact.CreationDate = DateTime.Now;
                }
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "Name", contact.CategoryID);
            ViewData["Admin"] = false;
            if (User.IsInRole("Admin"))
                ViewData["Admin"] = "true";

            return View(contact);
        }

        // GET: Contacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "Name", contact.CategoryID);
            ViewData["Admin"] = false;
            if (User.IsInRole("Admin"))
                ViewData["Admin"] = "true";

            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContactID,FirstName,LastName,Address,Town,Province,PostalCode,PhoneNumber,Email,CreationDate,CategoryID,Username")] Contact contact)
        {
            if (id != contact.ContactID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingContact = await _context.Contact.AsNoTracking().FirstOrDefaultAsync(c => c.ContactID == id);
                    if (existingContact == null)
                    {
                        return NotFound();
                    }

                    // Preserve non-editable values if user is not admin
                    if (!User.IsInRole("Admin"))
                    {
                        contact.Username = existingContact.Username;
                        contact.CreationDate = existingContact.CreationDate;
                    }


                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.ContactID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "Name", contact.CategoryID);
            ViewData["Admin"] = false;
            if (User.IsInRole("Admin"))
                ViewData["Admin"] = "true";

            return View(contact);
        }

        // GET: Contacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.ContactID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.Contact.FindAsync(id);
            if (contact != null)
            {
                _context.Contact.Remove(contact);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.ContactID == id);
        }
    }
}
