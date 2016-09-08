using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TravelBlog.Models
{
    public class TravelBlogDbContext : DbContext
    {
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet <Experience> Experiences { get; set; }
        public virtual DbSet <Person> People { get; set; }
        public virtual DbSet <PeopleExperiencesJoin> PeopleExperienceJoins { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<PeopleExperiencesJoin>()
                .HasKey(t => new { t.ExperienceId, t.PersonId });

            builder.Entity<PeopleExperiencesJoin>()
                .HasOne(pt => pt.Person)
                .WithMany(p => p.PeopleExperiencesJoins)
                .HasForeignKey(pt => pt.PersonId);

            builder.Entity<PeopleExperiencesJoin>()
                .HasOne(pt => pt.Experience)
                .WithMany(t => t.PeopleExperiencesJoins)
                .HasForeignKey(pt => pt.ExperienceId);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TravelBlog;integrated security=True");
        }
    }
}
