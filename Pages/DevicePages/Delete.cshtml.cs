using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigitalMatterPracticalExercise.Data;
using DigitalMatterPracticalExercise.Models;

namespace DigitalMatterPracticalExercise.Pages.DevicePages
{
    public class DeleteModel : PageModel
    {
        private readonly DigitalMatterPracticalExercise.Data.AdminContext _context;

        public DeleteModel(DigitalMatterPracticalExercise.Data.AdminContext context)
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

            var device = await _context.Device.FirstOrDefaultAsync(m => m.Id == id);

            if (device == null)
            {
                return NotFound();
            }
            else
            {
                Device = device;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = await _context.Device.FindAsync(id);
            if (device != null)
            {
                Device = device;
                _context.Device.Remove(Device);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
