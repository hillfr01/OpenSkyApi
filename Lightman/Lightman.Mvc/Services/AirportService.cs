namespace Lightman.Mvc.Services
{
    public class AirportService : IAirportService
    {
        ApplicationDbContext _dbContext { get; set; }
        public AirportService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string LookupAirportDescription(string code)
        {
            var airport = _dbContext.Airports.FirstOrDefault(x => x.Ident == code);
            if (airport == null)
            {
                return "Not Found";
            }

            return $"{airport.Ident} {airport.AirportName ?? ""}, {airport.Municipality}, {airport.IsoRegion} ({airport.AirportType ?? ""})";
        }
    }
}
