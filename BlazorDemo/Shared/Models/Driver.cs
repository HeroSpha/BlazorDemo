using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class Driver
    {
        public Driver()
        {
            CarTrips = new HashSet<CarTrip>();
        }
        public int DriverId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CarTrip> CarTrips { get; set; }
    }
}
