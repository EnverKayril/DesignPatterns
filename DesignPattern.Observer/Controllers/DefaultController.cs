using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Observer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser
            {
                UserName = model.UserName,
                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname
            };
            var result =  await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObservers(appUser);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
