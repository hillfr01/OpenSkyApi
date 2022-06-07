namespace Lightman.Mvc.Services
{
    public interface IFlightsService
    {
        public Models.Arrivals GetFlightsByTime(DateTime beginDateTime, DateTime endDateTime, string airportDepart, string airportArrive);
    }
}
