using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentHouse.Models
{
    public class familyDetail
    {

        public int Id { get; set; }

        [Display(Name = " Name")]
        public string CName { get; set; }

        [Display(Name = " House Name")]
        public string HName { get; set; }



        [Display(Name = "No of Person ")]
        public string PersonMem { get; set; }


    }
}
