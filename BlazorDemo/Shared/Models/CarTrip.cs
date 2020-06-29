using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class CarTrip
    {
        [Key]
        public int CarTripId { get; set; }
        public DateTime DateTime { get; set; }
        public int CarId { get; set; }
        public int TripId { get; set; }
        [ForeignKey("TripId")]
        public virtual Trip Trip { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
