using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class Driver
    {
        public Driver()
        {
            TripDetails = new HashSet<TripDetail>();
        }

        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public int DriverAge { get; set; }
        public string DriverGender { get; set; }

        public virtual ICollection<TripDetail> TripDetails { get; set; }
    }
}
