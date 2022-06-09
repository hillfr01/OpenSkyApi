using Lightman.Mvc.Models;
using Lightman.Mvc.Models.Datatables;

namespace Lightman.Mvc.Services
{
    public interface IFlightsService
    {
        ResultListWrapper<Flight> GetArrivals(DateTime beginDateTime, DateTime endDateTime, string airport);
    }
}
