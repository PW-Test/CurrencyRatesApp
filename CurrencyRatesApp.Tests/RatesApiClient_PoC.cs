using CurrencyRatesApp.Rates;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyRatesApp.Tests
{
    [TestFixture]
    public class RatesApiClient_PoC
    {
        [Test]
        public async Task when_fetching_ratesAsync()
        {
            var apiClient = new RatesApi();

            var response = await apiClient.ExecuteAsync<RatesResponse>();

            Assert.AreEqual(1, response.Currencies.Where(x => x.Code == "USD").Count());
            Assert.AreEqual(1, response.Currencies.Where(x => x.Code == "EUR").Count());
        }
    }
}
