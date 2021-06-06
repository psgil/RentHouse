using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentHouse.Models;

namespace RentHouse.Pages.home
{
    public class ViewHouseModel : PageModel
    {
        private readonly RentHouse.Data.RentHouseContext _context;

        public ViewHouseModel(RentHouse.Data.RentHouseContext context)
        {
            _context = context;
        }


        public IList<House> House { get; set; }

        public async Task OnGetAsync()
        {
            House = await _context.House.ToListAsync();
        }


    }
}
