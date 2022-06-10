using Lightman.Mvc.Models;
using Lightman.Mvc.Models.Datatables;
using Lightman.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace Lightman.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAirportService airportService;
        private readonly IFlightsService flightsService;

        public HomeController(IAirportService airportService, IFlightsService flightsService)
        {
            this.airportService = airportService;
            this.flightsService = flightsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new SearchForm();

            List<SelectListItem> selectListItems = new List<SelectListItem>();
            var airport1 = airportService.LookupAirportDescription("KMGY");
            var airport2 = airportService.LookupAirportDescription("KFFO");
            var airport3 = airportService.LookupAirportDescription("KDAY");
            var airport4 = airportService.LookupAirportDescription("KORD");

            selectListItems.Add(new SelectListItem() { Value = "KMGY", Text = airport1, Selected = true });
            selectListItems.Add(new SelectListItem() { Value = "KFFO", Text = airport2 });
            selectListItems.Add(new SelectListItem() { Value = "KDAY", Text = airport3 });
            selectListItems.Add(new SelectListItem() { Value = "KORD", Text = airport4 });
            ViewData[Util.Constants.ViewDataKeyForAirportSelect] = selectListItems; //put in view data so html dropdownlistfor helper can access

            model.StartDateTime = DateTime.Now.AddDays(-3);
            model.EndDateTime = DateTime.Now.AddDays(1);

            return View(model);
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), 200)]
        public DatatableResult GetArrivals([FromBody] DatatableParms p)
        {
            var searchValue = p.search?.value;
            ResultListWrapper<Flight> wrappedResults = flightsService.GetArrivals(beginDateTime: p.startDateTime, endDateTime: p.endDateTime, airport: p.airport);
            foreach (var flight in wrappedResults.Items)
            {
                flight.ArrivalAirportDescription = this.airportService.LookupAirportDescription(flight.estArrivalAirport);
                flight.DepartureAirportDescription = this.airportService.LookupAirportDescription(flight.estDepartureAirport);
            }

            var retVal = new DatatableResult()
            {
                data = wrappedResults.Items,
                draw = p.draw,
                recordsTotal = wrappedResults.TotalCount,
                recordsFiltered = wrappedResults.TotalCount
            };

            return retVal;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}