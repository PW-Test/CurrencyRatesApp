using CurrencyRatesApp.Rates;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CurrencyRatesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetRates()
        {
            var rates = new RatesProvider().Get(new List<string>() { "USD", "EUR" });

            return Json(rates, JsonRequestBehavior.AllowGet);
        }
    }
}