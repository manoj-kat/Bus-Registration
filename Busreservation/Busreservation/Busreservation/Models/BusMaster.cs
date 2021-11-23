using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class BusMaster
    {
        public BusMaster()
        {
            BusRoutes = new HashSet<BusRoute>();
            Pnrdetails = new HashSet<Pnrdetail>();
            TripDetails = new HashSet<TripDetail>();
        }

        public int BusId { get; set; }
        public string RegistrationNo { get; set; }
        public string BusName { get; set; }
        public string BusCondition { get; set; }
        public bool? BusStatus { get; set; }

        public virtual ICollection<BusRoute> BusRoutes { get; set; }
        public virtual ICollection<Pnrdetail> Pnrdetails { get; set; }
        public virtual ICollection<TripDetail> TripDetails { get; set; }
    }
}
