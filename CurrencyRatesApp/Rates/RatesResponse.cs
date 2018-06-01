using System.Collections.Generic;
using System.Xml.Serialization;

namespace CurrencyRatesApp.Rates
{
    [XmlRoot("web_dis_rates")]
    public class RatesResponse
    {
        [XmlElement("row")]
        public List<Currency> Currencies { get; set; }
    }

    public class Currency
    {
        [XmlElement("swift_code")]
        public string Code { get; set; }

        [XmlElement("swift_name")]
        public string Name { get; set; }

        [XmlElement("buy_cash")]
        public string BuyCash { get; set; }

        [XmlElement("sell_cash")]
        public string SellCash { get; set; }
    }
}