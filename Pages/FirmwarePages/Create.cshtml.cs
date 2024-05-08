using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DigitalMatterPracticalExercise.Data;
using DigitalMatterPracticalExercise.Models;

namespace DigitalMatterPracticalExercise.Pages.FirmwarePages
{
    public class CreateModel : PageModel
    {
        private readonly DigitalMatterPracticalExercise.Data.AdminContext _context;

        public CreateModel(DigitalMatterPracticalExercise.Data.AdminContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Firmware Firmware { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Firmware.Add(Firmware);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
