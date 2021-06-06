using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentHouse.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Display(Name = "House Name")]
        public string HName { get; set; }

        [Display(Name = "Customer Name ")]
        public string CName { get; set; }


        [Display(Name = "Price ")]
        public int Price { get; set; }

    }
}
