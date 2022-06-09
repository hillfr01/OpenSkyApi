using System.ComponentModel.DataAnnotations;

namespace Lightman.Mvc.Models
{
    public class Airport
    {
        [Key]
        [Required]
        public string Ident { get; set; }

        public string AirportType { get; set; }
        public string AirportName { get; set; }
        public string Continent { get; set; }
        public string IsoCountry { get; set; }
        public string IsoRegion { get; set; }
        public string Municipality { get; set; }
        public string GpsCode { get; set; }
        public string Coordinates { get; set; }

    }
}
