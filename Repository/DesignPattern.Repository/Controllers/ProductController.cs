using DesignPattern.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;

namespace DesignPattern.Repository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _productService.TProductListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> categories = (from x in _categoryService.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.v = categories;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var productValue = _productService.TGetById(id);
            _productService.TDelete(productValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _productService.TGetById(id);
            var categories = _categoryService.TGetList();

            var viewModel = new UpdateProductViewModel
            {
                Product = product,
                Categories = categories.Select(x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductViewModel viewModel)
        {
            var productToUpdate = _productService.TGetById(viewModel.Product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.ProductName = viewModel.Product.ProductName;
                productToUpdate.ProductPrice = viewModel.Product.ProductPrice;
                productToUpdate.ProductStock = viewModel.Product.ProductStock;
                productToUpdate.CategoryId = viewModel.Product.CategoryId;

                _productService.TUpdate(productToUpdate);
            }
            return RedirectToAction("Index");
        }
    }
}
