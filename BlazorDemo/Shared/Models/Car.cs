using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class Car
    {
        public Car()
        {
            CarTrips = new HashSet<CarTrip>();
        }
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CarTrip> CarTrips { get; set; }
    }
}
