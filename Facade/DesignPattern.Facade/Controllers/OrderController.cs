using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadeDesignPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        AppDbContext _context = new AppDbContext();
        

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            OrderFacede _orderFacede = new OrderFacede();
            _orderFacede.CompleteOrderDetail(customerId, productId, orderId, productCount, productPrice);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerId)
        {
            OrderFacede _orderFacede = new OrderFacede();
            _orderFacede.CompleteOrder(customerId);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
