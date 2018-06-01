using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyRatesApp.Rates
{
    public class RatesProvider
    {
        public IList<Currency> Get(IList<string> currencies)
        {
            return new RatesApi().Execute<RatesResponse>().Currencies.Where(x => currencies.Contains(x.Code)).ToList();
        }
    }
}