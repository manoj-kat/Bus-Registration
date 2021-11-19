using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class Pnrdetail
    {
        public Pnrdetail()
        {
            TransactDetails = new HashSet<TransactDetail>();
        }

        public int PnrNo { get; set; }
        public string UserId { get; set; }
        public int? BusId { get; set; }
        public string BusName { get; set; }
        public DateTime BookedOn { get; set; }
        public string PassName { get; set; }
        public string PassGender { get; set; }
        public int PassAge { get; set; }
        public string TravelFrom { get; set; }
        public string TravelTo { get; set; }
        public DateTime? Doj { get; set; }
        public string Seatno { get; set; }
        public double? Fare { get; set; }

        public virtual BusMaster Bus { get; set; }
        public virtual UserDetail User { get; set; }
        public virtual ICollection<TransactDetail> TransactDetails { get; set; }
    }
}
