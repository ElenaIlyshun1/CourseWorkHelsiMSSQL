using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkHelsiMSSQL.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Cities> Citiess { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
