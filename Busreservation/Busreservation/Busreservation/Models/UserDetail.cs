using System;
using System.Collections.Generic;

#nullable disable

namespace Busreservation.Models
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            Pnrdetails = new HashSet<Pnrdetail>();
            TransactDetails = new HashSet<TransactDetail>();
            Wallets = new HashSet<Wallet>();
        }

        public string UserId { get; set; }
        public string UserPass { get; set; }
        public string UserName { get; set; }
        public DateTime UserDoB { get; set; }
        public string UserMail { get; set; }
        public string UserPhn { get; set; }
        public string UserAddress { get; set; }

        public virtual ICollection<Pnrdetail> Pnrdetails { get; set; }
        public virtual ICollection<TransactDetail> TransactDetails { get; set; }
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
