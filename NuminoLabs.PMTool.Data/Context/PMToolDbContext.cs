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

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
                //in case you chagned the TKey type
                //  entity.HasKey(key => new { key.UserId, key.RoleId });
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
                //in case you chagned the TKey type
                //  entity.HasKey(key => new { key.ProviderKey, key.LoginProvider });       
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");

            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
                //in case you chagned the TKey type
                // entity.HasKey(key => new { key.UserId, key.LoginProvider, key.Name });

            });

            new ProjectConfiguration(modelBuilder.Entity<Project>());

        }

        //public PMToolDbContext(DbContextOptions<PMToolDbContext> options) : base(options)
        //{

        //}
        //public DbSet<Project> Projects { get; set; }

        //public virtual void Commit()
        //{
        //    base.SaveChanges();
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.AddConfiguration(new ProjectConfiguration());
        //}
    }
}
