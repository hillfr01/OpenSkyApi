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
            try
            {
                var airport = _dbContext.Airports.FirstOrDefault(x => x.Ident == code);
                if (airport == null)
                {
                    return $"{code} (Airport description not found)";
                }

                return $"{airport.Ident} {airport.AirportName ?? ""}, {airport.Municipality}, {airport.IsoRegion} ({airport.AirportType ?? ""})";
            }
            catch (Exception ex)
            {
                return $"{code} (Airport description not found)";
            }
        }
    }
}
