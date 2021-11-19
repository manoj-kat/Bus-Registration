using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class TripDetail
    {
        public string TripCode { get; set; }
        public string RouteId { get; set; }
        public int? BusId { get; set; }
        public int? DriverId { get; set; }
        public DateTime? TripDate { get; set; }
        public int NoOfSeatsBooked { get; set; }

        public virtual BusMaster Bus { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual BusRoute Route { get; set; }
    }
}
