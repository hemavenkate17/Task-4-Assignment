using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProfilePage.Models
{
    public class ProfileContext:DbContext
    {
        public ProfileContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Profile> Profiles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile() { ID = 1, Name = "ramu", Age = 20, Qualification = "B.Sc", IsEmployed = true, NoticePeriod = "One month", CurrentCTC = 45000 });
        }
    }
}
