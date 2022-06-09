namespace Lightman.Mvc.Models
{
    public class IndexViewModel
    {
        public string AirportArrival { get; set; }
        public string AirportDeparture { get; set; }
        public string FirstSeen { get; set; }
        public string LastSeen { get; set; }
        public string CallSign { get; set; }
        public string DistanceHorizontal { get; set; }
        public string DistanceVertical { get; set; }
        public ArrivalDepartureEnum ArrivalOrDeparture { get; set; }
        public string ArrivalOrDepartureString
        {
            get
            {
                return ArrivalOrDeparture.ToString();
            }
        }




    }
}
