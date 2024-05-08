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
    public class IndexModel : PageModel
    {
        private readonly DigitalMatterPracticalExercise.Data.AdminContext _context;

        public IndexModel(DigitalMatterPracticalExercise.Data.AdminContext context)
        {
            _context = context;
        }

        public IList<Device> Device { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Device = await _context.Devices.ToListAsync();
        }
    }
}
