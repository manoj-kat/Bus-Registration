using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class BusRoute
    {
        public BusRoute()
        {
            TripDetails = new HashSet<TripDetail>();
        }

        public int BusId { get; set; }
        public string RouteId { get; set; }
        public string BusSource { get; set; }
        public string BusDestination { get; set; }

        public virtual BusMaster Bus { get; set; }
        public virtual ICollection<TripDetail> TripDetails { get; set; }
    }
}
