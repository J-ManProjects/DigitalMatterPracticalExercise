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

namespace DigitalMatterPracticalExercise.Pages.DevicePages
{
    public class EditModel : PageModel
    {
        private readonly DigitalMatterPracticalExercise.Data.AdminContext _context;

        public EditModel(DigitalMatterPracticalExercise.Data.AdminContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Device Device { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device =  await _context.Device.FirstOrDefaultAsync(m => m.Id == id);
            if (device == null)
            {
                return NotFound();
            }
            Device = device;
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

            _context.Attach(Device).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceExists(Device.Id))
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

        private bool DeviceExists(int id)
        {
            return _context.Device.Any(e => e.Id == id);
        }
    }
}
