using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class Trip
    {
        public Trip()
        {
            CarTrips = new HashSet<CarTrip>();
        }
        [Key]
        public int TripId { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public virtual ICollection<CarTrip> CarTrips { get; set; }
    }
}
