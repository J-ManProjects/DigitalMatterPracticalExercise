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

        public DbSet<DigitalMatterPracticalExercise.Models.Device> Devices { get; set; } = default!;
        public DbSet<DigitalMatterPracticalExercise.Models.Firmware> Firmware { get; set; } = default!;
        public DbSet<DigitalMatterPracticalExercise.Models.Group> Groups { get; set; } = default!;
        public DbSet<DigitalMatterPracticalExercise.Models.Connection> Connections { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>().ToTable(nameof(Device));
            modelBuilder.Entity<Firmware>().ToTable(nameof(Firmware));
            modelBuilder.Entity<Group>().ToTable(nameof(Group));
            modelBuilder.Entity<Connection>().ToTable(nameof(Connection));
        }
    }
}
