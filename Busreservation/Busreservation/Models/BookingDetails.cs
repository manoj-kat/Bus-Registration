using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Busreservation.Models
{
    public class BookingDetails
    {
        [DisplayName("PNR Number")]
        public int PnrNo { get; set; }
        [DisplayName("User ID")]
        public string UserId { get; set; }
        [DisplayName("Bus ID")]
        public int? BusId { get; set; }
        [DisplayName("Date of Booking")]
        [DataType(DataType.Date)]
        public DateTime BookedOn { get; set; }
       
        [DisplayName("From")]
        public string TravelFrom { get; set; }
        [DisplayName("To")]
        public string TravelTo { get; set; }
        [DisplayName("Date Of Journey")]
        [DataType(DataType.Date)]
        public DateTime? Doj { get; set; }
        
        [DisplayName("Fare")]
        public double? Fare { get; set; }

        public List<PassengerDetails> PassengerDetails { get; set; }
    }
     public class PassengerDetails
    {
        [DisplayName("Passenger Name")]
        public string PassName { get; set; }
        [DisplayName("Gender")]
        public string PassGender { get; set; }
        [DisplayName("Age")]
        public int PassAge { get; set; }
        [DisplayName("Seat no")]
        
        public string Seatno { get; set; }
    }
}
