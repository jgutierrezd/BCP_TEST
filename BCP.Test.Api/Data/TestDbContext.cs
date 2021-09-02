﻿using BCP.Test.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCP.Test.Api.Data
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Rate> Rates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.HasKey(up => new { up.Id });
                entity.HasAlternateKey(up => new { up.CurrencyOrigin, up.CurrencyDestiny, up.IsMultiplier });

                entity.Property(e => e.CurrencyOrigin)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CurrencyDestiny)
                    .IsRequired()
                    .HasMaxLength(3);
            });
            //modelBuilder.Entity<Rate>().HasData(
            //    new Rate { CurrencyOrigin = "PEN", rate = 4.1m, CurrencyDestiny = "USD", IsMultiplier = false },
            //    new Rate { CurrencyOrigin = "USD", rate = 3.9m, CurrencyDestiny = "PEN", IsMultiplier = true }
            //);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
