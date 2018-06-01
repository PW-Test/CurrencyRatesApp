using RestSharp;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CurrencyRatesApp.Rates
{
    public class RatesApi
    {
        readonly string BaseUrl = "https://www.forex.se/";

        public async Task<T> ExecuteAsync<T>() where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(BaseUrl, UriKind.Absolute);

            var request = new RestRequest("ratesxml.asp?id=492");
            request.RequestFormat = DataFormat.Xml;

            var taskCompletionSource = new TaskCompletionSource<T>();
            var serializer = new XmlSerializer(typeof(T));

            client.ExecuteAsync<T>(request, (response) => {
                var stringReader = new StringReader(response.Content);
                taskCompletionSource.SetResult((T)serializer.Deserialize(stringReader));
            });

            return await taskCompletionSource.Task;
        }
    }
}