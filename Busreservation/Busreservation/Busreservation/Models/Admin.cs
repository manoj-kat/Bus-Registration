using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Busreservation.Models
{
    public class Admin
    {

        [Required]
        public string adminId { get; set; }
        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        public string adminpass { get; set; }
    }

}
