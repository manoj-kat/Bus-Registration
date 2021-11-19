using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Busreservation.View_Model
{
    public class loginviewmodel
    {
        [Required(ErrorMessage = "Please Enter Email...")]
        [Display(Name = "Email")]
        public string UserMail { get; set; }

        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        public string UserPass { get; set; }
    }
}
