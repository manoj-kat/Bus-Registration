using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Busreservation.Models
{
    public class DisplayBus
    {
        [Key]
        public int DisplayId { get; set; }
        public int BusId { get; set; }
        public string RouteId { get; set; }
        [DisplayName("Bus Name")]
        public string BusName { get; set; }
        [DisplayName("Bus Type")]
        public string BusCondition { get; set; }
        [DisplayName("Source")]
        public string BusSource { get; set; }
        [DisplayName("Destination")]
        public string BusDestination { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date Of Journey")]
        public DateTime Doj { get; set; }

    }
}
