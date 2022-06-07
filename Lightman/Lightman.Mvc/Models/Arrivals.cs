namespace Lightman.Mvc.Models
{
    public class Arrivals
    {
        public string icao24 { get; set; }
        //Start of time interval to retrieve flights for as Unix time(seconds since epoch)
        public int firstSeen { get; set; }
        //ICAO identier for the airport
        public string estDepartureAirport { get; set; }
        //Start of time interval to retrieve flights for as Unix time (seconds since epoch)
        public int lastSeen { get; set; }
        //ICAO identier for the airport
        public string estArrivalAirport { get; set; }
        public string callsign { get; set; }
        public int estDepartureAirportHorizDistance { get; set; }
        public int estDepartureAirportVertDistance { get; set; }
        public int estArrivalAirportHorizDistance { get; set; }
        public int estArrivalAirportVertDistance { get; set; }
        public int departureAirportCandidatesCount { get; set; }
        public int arrivalAirportCandidatesCount { get; set; }

        public string firstSeenDateTime
        {
            get
            {
                try
                {
                    return DateTimeOffset.FromUnixTimeSeconds(firstSeen).ToString("yyyy MM dd \nhh:mm tt");
                }
                catch
                {
                    return "NULL";
                }
            }
        }
        public string lastSeenDateTime
        {
            get
            {
                try
                {
                    return DateTimeOffset.FromUnixTimeSeconds(lastSeen).ToString("yyyy MM dd \nhh:mm tt");
                }
                catch
                {
                    return "NULL";
                }
            }
        }
    }
}
