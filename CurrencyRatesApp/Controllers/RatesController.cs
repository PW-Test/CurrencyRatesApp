using CurrencyRatesApp.Rates;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CurrencyRatesApp.Controllers
{
    public class RatesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetRates()
        {
            var provider = new RatesProvider();
            var rates = await provider.Get(new List<string>() { "USD", "EUR" });

            return Json(rates, JsonRequestBehavior.AllowGet);
        }
    }
}