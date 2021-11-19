using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class Wallet
    {
        public int WalletId { get; set; }
        public string UserId { get; set; }
        public double? WalletBalance { get; set; }

        public virtual UserDetail User { get; set; }
    }
}
