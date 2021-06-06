using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentHouse.Data;
using RentHouse.Models;

namespace RentHouse.Pages.home
{
    public class DeleteModel : PageModel
    {
        private readonly RentHouse.Data.RentHouseContext _context;

        public DeleteModel(RentHouse.Data.RentHouseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public House House { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            House = await _context.House.FirstOrDefaultAsync(m => m.Id == id);

            if (House == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            House = await _context.House.FindAsync(id);

            if (House != null)
            {
                _context.House.Remove(House);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
