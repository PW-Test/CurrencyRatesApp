using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CurrencyRatesApp.Rates
{
    public class RatesProvider
    {
        public async Task<IList<Currency>> Get(IList<string> currencies)
        {
            var api = new RatesApi();
            var response = await api.ExecuteAsync<RatesResponse>();

            return response.Currencies.Where(x => currencies.Contains(x.Code)).ToList();
        }
    }
}