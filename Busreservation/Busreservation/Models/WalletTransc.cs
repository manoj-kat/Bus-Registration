using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class WalletTransc
    {
        public int? TransactId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double? Amount { get; set; }
        public string CreditOrDebit { get; set; }
        public int? WalletId { get; set; }

        public virtual TransactDetail Transact { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}
