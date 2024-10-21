using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class CustomerController : Controller
    {
        AppDbContext _context = new AppDbContext();

        [HttpGet]
        public IActionResult AddNewCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("CustomerList");
        }

        public IActionResult CustomerList()
        {
            var values = _context.Customers.ToList();
            return View(values);
        }
    }
}
