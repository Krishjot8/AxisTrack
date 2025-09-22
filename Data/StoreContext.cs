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

        public DbSet<ProjectTask> ProjectTasks { get; set; }


        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Project -> ProjectTasks relationship
            modelBuilder.Entity<ProjectTask>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(pt => pt.ProjectId)
                .OnDelete(DeleteBehavior.Cascade); // optional
        }

    }



}

