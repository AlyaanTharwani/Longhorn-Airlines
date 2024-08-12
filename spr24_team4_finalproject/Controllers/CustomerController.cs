using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using spr24_team4_finalproject.DAL;
using spr24_team4_finalproject.Models;
using spr24_team4_finalproject.Utilities;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace spr24_team4_finalproject.Controllers
{
    [Authorize(Roles = "Gate Agent,Manager")]
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public CustomerController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Customer/Search
        public IActionResult Search()
        {
            var allCustomers = _context.Users.Where(u => u.AdvNumber != null).ToList();

            return View(allCustomers);
        }

        // POST: Customer/SearchResults
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchResults(string searchString, bool searchByAdvantageNumber = false)
        {
            IEnumerable<AppUser> filteredCustomers;

            if (string.IsNullOrEmpty(searchString))
            {
                return View("Search", _context.Users.Where(u => u.AdvNumber != null).ToList());
            }

            if (searchByAdvantageNumber)
            {
                if (int.TryParse(searchString, out int advNumber))
                {
                    // Filter by valid Advantage Number
                    filteredCustomers = _context.Users.Where(u => u.AdvNumber == advNumber).ToList();
                }
                else
                {
                    ModelState.AddModelError("", "Advantage number must be a valid integer.");
                    return View("Search", _context.Users.Where(u => u.AdvNumber != null).ToList());
                }
            }
            else
            {
                // Filter by name but ensure they have an Advantage Number
                filteredCustomers = _context.Users
                    .Where(u => (u.LastName.Contains(searchString) || u.FirstName.Contains(searchString)) && u.AdvNumber != null)
                    .ToList();
            }

            return View("Search", filteredCustomers);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegisterViewModel model)
        {
            if (ModelState.IsValid != false)
            {
                return View(model);
            }

            // Map the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                MiddleInitial = model.MiddleInitial,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                Street = model.Street,
                City = model.City,
                State = model.State,
                Zip = model.Zip,
                AdvNumber = GenerateAdvantageNumber() // Assumes implementation exists to generate this number
            };

            // Prepare the user and role data
            AddUserModel aum = new AddUserModel
            {
                User = newUser,
                Password = model.Password,
                RoleName = "Customer"
            };

            // Attempt to add the user with role
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded)
            {
                // Redirect to the Confirmation action in CustomerController on successful user creation
               
                return RedirectToAction("Index", "RoleAdmin");
            }
            else
            {
                // If there were errors, add them to the ModelState and return to the form
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }
        }

        //ADVANTAGE NUMBER GENERATION
        private int GenerateAdvantageNumber()
        {
            return _context.Users.Max(u => u.AdvNumber ?? 4999) + 1;
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return View("Error", new string[] { "Please specify a customer to edit!" });
            }

            var customer = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return View("Error", new string[] { "This customer was not found!" });
            }

            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,FirstName,LastName,Email,PhoneNumber,Street,City,State,Zip")] AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Fetch the latest version of the entity from the database
                    var existingCustomer = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
                    if (existingCustomer == null)
                    {
                        return NotFound();
                    }

                    // Update the properties of the existing entity
                    existingCustomer.FirstName = appUser.FirstName;
                    existingCustomer.LastName = appUser.LastName;
                    existingCustomer.Email = appUser.Email;
                    existingCustomer.PhoneNumber = appUser.PhoneNumber;
                    existingCustomer.Street = appUser.Street;
                    existingCustomer.City = appUser.City;
                    existingCustomer.State = appUser.State;
                    existingCustomer.Zip = appUser.Zip;

                    // Update the entity in the context and save changes
                    _context.Update(existingCustomer);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Search));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(appUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return View(appUser);
        }


        private bool CustomerExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        // GET: Customer/Confirmation
        public IActionResult Confirmation()
        {
            return View();
        }


    }
}
