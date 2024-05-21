using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.App.Infrastructure.Db
{
    public class AppointmentContext: DbContext
    {
        public AppointmentContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Models.Appointment> Appointments { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Datasource=Appointments.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Appointment>().ToTable("Appointments");
        }
    }
}
