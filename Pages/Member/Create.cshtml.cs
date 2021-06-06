using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentHouse.Data;
using RentHouse.Models;

namespace RentHouse.Pages.Member
{
    public class CreateModel : PageModel
    {
        private readonly RentHouse.Data.RentHouseContext _context;

        public CreateModel(RentHouse.Data.RentHouseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public familyDetail familyDetail { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.familyDetail.Add(familyDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
