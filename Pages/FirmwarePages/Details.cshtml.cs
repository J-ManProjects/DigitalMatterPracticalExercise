using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DigitalMatterPracticalExercise.Data;
using DigitalMatterPracticalExercise.Models;

namespace DigitalMatterPracticalExercise.Pages.FirmwarePages
{
    public class DetailsModel : PageModel
    {
        private readonly DigitalMatterPracticalExercise.Data.AdminContext _context;

        public DetailsModel(DigitalMatterPracticalExercise.Data.AdminContext context)
        {
            _context = context;
        }

        public Firmware Firmware { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firmware = await _context.Firmware.FirstOrDefaultAsync(m => m.Id == id);
            if (firmware == null)
            {
                return NotFound();
            }
            else
            {
                Firmware = firmware;
            }
            return Page();
        }
    }
}
