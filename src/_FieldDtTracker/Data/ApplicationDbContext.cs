using _FieldDtTracker.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _FieldDtTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<FieldDtTrackerUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //adding table in the DbContext by using DbSet
        public DbSet<Region> Regions { get; set; } = null!; // null! for a Non optional table
        public DbSet<Departement> Departements { get; set; } = null!;
        public DbSet<Commune> Communes { get; set; } = null!;
        public DbSet<HACPtable> HACPtables { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasKey(x => x.Id);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Program).Assembly);

        }


    }
}