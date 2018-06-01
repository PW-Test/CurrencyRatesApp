using CurrencyRatesApp.Rates;
using NUnit.Framework;
using System.Linq;


namespace CurrencyRatesApp.Tests
{
    [TestFixture]
    public class RatesApiClient_PoC
    {
        [Test]
        public void when_fetching_rates()
        {
            var apiClient = new RatesApi();

            var response = apiClient.Execute<RatesResponse>();

            Assert.AreEqual(1, response.Currencies.Where(x => x.Code == "USD").Count());
            Assert.AreEqual(1, response.Currencies.Where(x => x.Code == "EUR").Count());
        }
    }
}
