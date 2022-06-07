namespace Lightman.Mvc.Services
{
    public class FlightsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUri;
        public FlightsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _baseUri = "https://opensky-network.org/api/flights/";
        }
        //public Models.Arrivals GetFlightsByTime(DateTime beginDateTime, DateTime endDateTime, string airport)
        //{

        //    var uri = $"{_baseUri}arrival?begin={beginUnixEpochSeconds}&end={endUnixEpochSeconds}&airport={airport}"
        //    var responseString = await _httpClient.GetStringAsync(uri);
        //}
    }
}
