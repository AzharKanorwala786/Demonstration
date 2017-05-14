using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demonstartion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string iPAddress)
        {
            GeoService.GeoIPService service = new GeoService.GeoIPService();
            GeoService.GeoIP output = service.GetGeoIP(iPAddress.Trim());
            ViewBag.Country = "Country: " + output.CountryName;

            return View();
        }
            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}