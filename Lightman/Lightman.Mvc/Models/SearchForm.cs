using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Lightman.Mvc.Models
{
    public class SearchForm
    {
        [Display(Name = "Timestamp")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get { return DateTime.UtcNow; } }

        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDateTime { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDateTime { get; set; }

        [Display(Name = "Arrival Airport")]
        public string AirportCode { get; set; }

        [Display(Name = "Airport")]
        public string AirportDescription { get; set; }

        public ArrivalDepartureEnum ArrivalOrDeparture { get; set; }
        public List<SelectListItem> AirportSelectListItems { get; set; }

    }
}
