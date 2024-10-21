using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext _context = new AppDbContext();

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductList()
        {
            var values = _context.Products.ToList();
            return View(values);
        }
    }
}
