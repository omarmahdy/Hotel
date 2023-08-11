using Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.ObjectiveC;

namespace Hotel.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Reservation> Reservatons { get; set; }
        
        public DbSet<Admin> Admin { get; set; }


    }
}
