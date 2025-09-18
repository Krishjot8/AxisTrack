using AxisTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace AxisTrack.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

         

        
        }


        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectTask> TaskItems { get; set; }


        public DbSet<Category> Categories { get; set; }
    }
}
