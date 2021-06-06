using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentHouse.Data;
using RentHouse.Models;

namespace RentHouse.Pages.Member
{
    public class DetailsModel : PageModel
    {
        private readonly RentHouse.Data.RentHouseContext _context;

        public DetailsModel(RentHouse.Data.RentHouseContext context)
        {
            _context = context;
        }

        public familyDetail familyDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            familyDetail = await _context.familyDetail.FirstOrDefaultAsync(m => m.Id == id);

            if (familyDetail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
