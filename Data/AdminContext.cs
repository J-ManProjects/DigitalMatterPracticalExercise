using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DigitalMatterPracticalExercise.Models;

namespace DigitalMatterPracticalExercise.Data
{
    public class AdminContext : DbContext
    {
        public AdminContext (DbContextOptions<AdminContext> options)
            : base(options)
        {
        }

        public DbSet<DigitalMatterPracticalExercise.Models.Device> Device { get; set; } = default!;
        public DbSet<DigitalMatterPracticalExercise.Models.Firmware> Firmware { get; set; } = default!;
        public DbSet<DigitalMatterPracticalExercise.Models.Group> Group { get; set; } = default!;
    }
}
