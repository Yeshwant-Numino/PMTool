using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuminoLabs.PMTool.Data.Configuration;
using NuminoLabs.PMTool.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuminoLabs.PMTool.Data.Context
{
    public class PMToolDbContext : IdentityDbContext<User>
    {

        public PMToolDbContext(DbContextOptions<PMToolDbContext> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>{entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity => {entity.ToTable(name: "Role");});
            modelBuilder.Entity<IdentityUserRole<string>>(entity => {entity.ToTable("UserRoles");});
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => {entity.ToTable("UserClaims");});
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => {entity.ToTable("UserLogins");});
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => {entity.ToTable("RoleClaims");});
            modelBuilder.Entity<IdentityUserToken<string>>(entity => {entity.ToTable("UserTokens");});
            modelBuilder.Entity<User>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(80));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(80));

            new ProjectConfiguration(modelBuilder.Entity<Project>());

        }
    }
}
