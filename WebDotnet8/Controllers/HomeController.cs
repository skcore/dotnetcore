using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDotnet8.Models;

namespace WebDotnet8.Controllers
{
    public class HomeController : Controller
    {
        private List<Customer> filteredUsers = new List<Customer>();
        public IActionResult Index(string sortOrder, string nameFilter, int page = 1)
        {
            Customer customer = new Customer();

            filteredUsers = customer.GetCustomers();

            if (!string.IsNullOrEmpty(nameFilter))
            {
                filteredUsers = filteredUsers.Where(u => (u.Name.Contains(nameFilter, StringComparison.OrdinalIgnoreCase) || u.Department.Contains(nameFilter, StringComparison.OrdinalIgnoreCase))).ToList();
            }

            // Set the default sorting order if it's not provided
            if (string.IsNullOrEmpty(sortOrder))
            {
                sortOrder = "id";
            }

            ViewBag.SortDirection = "asc"; // Default sorting direction

            // Toggle the sorting direction if the same column is clicked again
            if (ViewBag.SortOrder != null)
            {
                if (sortOrder.Equals(ViewBag.SortOrder, StringComparison.OrdinalIgnoreCase))
                {
                    ViewBag.SortDirection = (ViewBag.SortDirection == "asc") ? "desc" : "asc";
                }
            }
            switch (sortOrder.ToLower())
            {
                case "id":
                    filteredUsers = filteredUsers.OrderBy(u => u.ID).ToList();
                    break;
                case "name":
                    filteredUsers = filteredUsers.OrderBy(u => u.Name).ToList();
                    break;
                case "department":
                    filteredUsers = filteredUsers.OrderBy(u => u.Department).ToList();
                    break;
                // Add more cases for additional columns if needed
                default:
                    filteredUsers = filteredUsers.OrderBy(u => u.ID).ToList();
                    break;
            }

            int pageSize = 5;
            int totalPages = (int)Math.Ceiling((double)filteredUsers.Count() / pageSize);

            var usersToDisplay = filteredUsers.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.Page = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.SortOrder = sortOrder;
            ViewBag.NameFilter = nameFilter;

            return View(usersToDisplay);
        }
        // Action for handling inline edit
        [HttpPost]
        public IActionResult Edit(int Id, string Name, string Department, string City)
        {
            // Perform update logic here
            // ...

            return RedirectToAction("Index");
        }

        // Action for handling delete
        [HttpPost]
        public IActionResult Delete(int customerId)
        {
            // Perform delete logic here
            // ...

            return RedirectToAction("Index");
        }

        // Action for handling add
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            // Perform add logic here
            // ...

            return RedirectToAction("Index");
        }
    }
}
