using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(29.99);
            ViewBag.v4 = netflixPlans.Resolution("HD");
            ViewBag.v5 = netflixPlans.Content("Film, Dizi");
            return View();
        }

        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(49.99);
            ViewBag.v4 = netflixPlans.Resolution("FHD");
            ViewBag.v5 = netflixPlans.Content("Film, Dizi, Animasyon");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(99.99);
            ViewBag.v4 = netflixPlans.Resolution("4K");
            ViewBag.v5 = netflixPlans.Content("Film, Dizi, Animasyon, Belgesel");
            return View();
        }
    }
}
