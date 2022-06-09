using Lightman.Mvc.Models;
using Lightman.Mvc.Models.Datatables;
using System.Text.Json;

namespace Lightman.Mvc.Services
{
    public class FlightsService : IFlightsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUri;
        public FlightsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUri = "https://opensky-network.org/api/flights/";
        }

        public ResultListWrapper<Flight> GetArrivals(DateTime beginDateTime, DateTime endDateTime, string airport)
        {
            var beginUnixEpochSeconds = Util.DotNetDateTimeToUnixEpochSeconds(beginDateTime);
            var endUnixEpochSeconds = Util.DotNetDateTimeToUnixEpochSeconds(endDateTime);
            var uri = $"{_baseUri}arrival?begin={beginUnixEpochSeconds}&end={endUnixEpochSeconds}&airport={airport}";
            var responseString = _httpClient.GetStringAsync(uri).Result;
            List<Flight> flights = JsonSerializer.Deserialize<List<Flight>>(responseString);
            int totalCount = flights.Count();
            var resultListWrapper = new ResultListWrapper<Flight>(flights, totalCount);
            return resultListWrapper;
        }

        public Flight GetDepartures(DateTime beginDateTime, DateTime endDateTime, string airport)
        {
            throw new NotImplementedException();
        }
    }
}
