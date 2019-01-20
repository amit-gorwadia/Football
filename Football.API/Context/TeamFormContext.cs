using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Football.Data.Entity;

namespace Football.API.Context
{
    public class TeamFormContext : DbContext
    {
        public TeamFormContext(DbContextOptions<TeamFormContext> options)
            :base(options)
        { }

        public TeamFormContext()
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<County>()
                .ToTable("County");
            modelBuilder
                .Entity<County>()
                .HasKey(k => k.Id);
            modelBuilder
                .Entity<County>()                
                .HasIndex(i=>i.Name)
                .IsUnique();               
        }
    }
}
