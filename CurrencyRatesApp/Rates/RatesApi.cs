using RestSharp;
using System;
using System.IO;
using System.Xml.Serialization;

namespace CurrencyRatesApp.Rates
{
    public class RatesApi
    {
        readonly string BaseUrl = "https://www.forex.se/";

        public T Execute<T>() where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl, UriKind.Absolute);

            var request = new RestRequest("ratesxml.asp?id=492");
            request.RequestFormat = DataFormat.Xml;

            var response = client.Execute(request);

            if (response.ErrorException != null)
            {
                throw new ApplicationException("Error during rest call execution", response.ErrorException);
            }

            var serializer = new XmlSerializer(typeof(T));
            var stringReader = new StringReader(response.Content);

            return (T)serializer.Deserialize(stringReader);
        }
    }
}