using System.Web.Mvc;
using CurrencyRatesApp.Controllers;
using NUnit.Framework;

namespace CurrencyRatesApp.Tests.Controllers
{
    [TestFixture]
    public class RatesControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            RatesController controller = new RatesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
