using DesignPattern.Composite.CompositePattern;
using DesignPattern.Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AppDbContext _context;

        public DefaultController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.Include(x => x.Products).ToList();
            var values = Recursive(categories, new Category { CategoryName = "FirstCategory", CategoryId = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v1 = values;
            return View();
        }

        public ProductComposite Recursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.CategoryId).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryId, y.CategoryName);
                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductId, z.Name));
                });

                if (leaf == null)
                {
                    firstComposite.Add(productComposite);
                }
                else
                {
                    leaf.Add(productComposite);
                }
                Recursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
