using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MohamedAhmed._0523059.Data.Models;

namespace MohamedAhmed._0523059.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Coach> coaches { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Player> players { get; set; }   
        public DbSet<Competition> competitions { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Player>().HasOne( x => x.Team).
        //        WithMany( x => x.Players).HasForeignKey( x => x.TeamID );

        //    modelBuilder.Entity<Coach>().HasOne(x => x.team).
        //        WithOne(x => x.Coach).HasForeignKey(x => x.CoachID);

        //    modelBuilder.Entity<Team>().HasOne(x => x.Coach).
        //        WithOne(x => x.team).HasForeignKey( a => a.);


        //    //modelBuilder.Entity<Team>().HasMany(x => x.Competitions).WithMany(x => x.Teams).
        //    //    UsingEntity(x => x.ToTable("TeamCompetition")).HasData({
        //    //    new { competitionId = 1, TeamId = 1 },

        //    modelBuilder.Entity<Team>().HasMany(x => x.Competitions).WithMany(x => x.Teams).UsingEntity(x => x.HasData(

        //        new {}

        //        ));

        //    //});

        //    //modelBuilder.Entity<Coach>().HasData(
        //    //    new { id = 1, name = " mohamed ", Specialization = " Football", ExperrienceYears = 1 }
        //    //);










        //}




    }
}
