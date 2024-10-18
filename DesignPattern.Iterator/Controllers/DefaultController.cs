
using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
       

        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Germany", CityName = "Berlin", VisitPlaceName = "Brandenburg Gate" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Germany", CityName = "Berlin", VisitPlaceName = "Reichstag Building" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Germany", CityName = "Berlin", VisitPlaceName = "Berlin Wall" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Germany", CityName = "Munich", VisitPlaceName = "Marienplatz" });
            visitRouteMover.AddVisitRoute(new VisitRoute { CountryName = "Germany", CityName = "Munich", VisitPlaceName = "Nymphenburg Palace" });

            var iterator = visitRouteMover.CreateIterator();
            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName + " - " + iterator.CurrentItem.CityName + " - " + iterator.CurrentItem.VisitPlaceName);
            }

            ViewBag.VisitRoutes = strings;

            return View();
        }
    }
}
