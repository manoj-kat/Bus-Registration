using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Busreservation.Models
{
    public class Search
    {
        [Key]
        public int SearchId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfJourney { get; set; }
    }
}
