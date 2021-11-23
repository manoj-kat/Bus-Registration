using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class TransactDetail
    {
        public int TransactId { get; set; }
        public string UserId { get; set; }
        public int? PnrNo { get; set; }
        public DateTime TransactTime { get; set; }
        public decimal? TotalAmount { get; set; }
        public string PaymentOption { get; set; }
        public string Paymentstatus { get; set; }

        public virtual Pnrdetail PnrNoNavigation { get; set; }
        public virtual UserDetail User { get; set; }
    }
}
