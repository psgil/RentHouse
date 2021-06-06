using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentHouse.Models
{
    public class Register
    {

        public int Id { get; set; }

        [Display(Name = "Name")]
        public string UName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }


    }
}
