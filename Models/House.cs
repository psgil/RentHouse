using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentHouse.Models
{
    public class House
    {
        public int Id { get; set; }

        [Display(Name = "House Name")]
        public string HName { get; set; }

        [Display(Name = "Specification ")]
        public string Specification { get; set; }


        [Display(Name = "Price ")]
        public int Price { get; set; }
    }
}
