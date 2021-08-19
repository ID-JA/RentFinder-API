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
                .HasKey(f => new { f.UserId, f.AnnouncementId });

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.ApplicationUser)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Announcement)
                .WithMany(a => a.Favorites)
                .HasForeignKey(f => f.AnnouncementId)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<Rating>()
                .HasKey(r => new { r.UserId, r.AnnouncementId});

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.ApplicationUser)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Announcement)
                .WithMany(a => a.Ratings)
                .HasForeignKey(r => r.AnnouncementId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
    }
}
