using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigitalMatterPracticalExercise.Data;
using DigitalMatterPracticalExercise.Models;

namespace DigitalMatterPracticalExercise.Pages.FirmwarePages
{
    public class EditModel : PageModel
    {
        private readonly DigitalMatterPracticalExercise.Data.AdminContext _context;

        public EditModel(DigitalMatterPracticalExercise.Data.AdminContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Firmware Firmware { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firmware =  await _context.Firmware.FirstOrDefaultAsync(m => m.Id == id);
            if (firmware == null)
            {
                return NotFound();
            }
            Firmware = firmware;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Firmware).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FirmwareExists(Firmware.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FirmwareExists(int id)
        {
            return _context.Firmware.Any(e => e.Id == id);
        }
    }
}
