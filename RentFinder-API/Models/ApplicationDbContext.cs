using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentFinder_API.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Favorite>()
                .HasKey(f => new { f.IdAnnouncement, f.IdUser });

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.IdUser);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Announcement)
                .WithMany(a => a.Favorites)
                .HasForeignKey(f => f.IdAnnouncement);



            modelBuilder.Entity<Rating>()
                .HasKey(r => new { r.IdAnnouncement, r.IdUser });

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.IdUser);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Announcement)
                .WithMany(a => a.Ratings)
                .HasForeignKey(r => r.IdAnnouncement);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
