using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreIdentitySampleProj.Data
{
    public class ApplicationDbContext : IdentityDbContext<
        ApplicationUser,
        ApplicationRole,
        string,
        ApplicationUserClaim,
        ApplicationUserRole,
        ApplicationUserLogin,
        ApplicationRoleClaim,
        ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("CustomIdentityUser");
            });

            modelBuilder.Entity<ApplicationUserClaim>(b =>
            {
                b.ToTable("CustomIdentityUserClaim");
            });

            modelBuilder.Entity<ApplicationUserLogin>(b =>
            {
                b.ToTable("CustomIdentityUserLogin");
                b.HasKey("UserId");
            });

            modelBuilder.Entity<ApplicationUserToken>(b =>
            {
                b.ToTable("CustomIdentityUserToken");
                b.HasKey("UserId");
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.ToTable("CustomIdentityRole");
            });

            modelBuilder.Entity<ApplicationRoleClaim>(b =>
            {
                b.ToTable("CustomIdentityRoleClaim");
            });

            modelBuilder.Entity<ApplicationUserRole>(b =>
            {
                b.ToTable("CustomIdentityUserRole");
                b.HasKey("UserId", "RoleId");
            });
        }

    }
}
