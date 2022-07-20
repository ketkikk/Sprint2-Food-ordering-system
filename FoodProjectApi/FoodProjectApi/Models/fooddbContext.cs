﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FoodProjectApi.Models
{
    public partial class fooddbContext : DbContext
    {
        public fooddbContext()
        {
        }

        public fooddbContext(DbContextOptions<fooddbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FoodDetail> FoodDetails { get; set; }
        public virtual DbSet<FoodDetailsAdmin> FoodDetailsAdmins { get; set; }
        public virtual DbSet<OrderTbl> OrderTbls { get; set; }
        public virtual DbSet<RegisterTbl> RegisterTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-VI23QLJ7\\MSSQLESERVER3;Initial Catalog=fooddb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FoodDetail>(entity =>
            {
                entity.Property(e => e.FoodDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("foodDescription");

                entity.Property(e => e.FoodDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("foodDiscount");

                entity.Property(e => e.FoodFinal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("foodFinal");

                entity.Property(e => e.FoodImage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("foodImage");

                entity.Property(e => e.FoodMrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("foodMrp");

                entity.Property(e => e.FoodName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("foodName");

                entity.Property(e => e.FoodQuantity).HasColumnName("foodQuantity");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.RestaurantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("restaurantName");
            });

            modelBuilder.Entity<FoodDetailsAdmin>(entity =>
            {
                entity.ToTable("FoodDetailsAdmin");

                entity.Property(e => e.FoodDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("foodDescription");

                entity.Property(e => e.FoodDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("foodDiscount");

                entity.Property(e => e.FoodFinal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("foodFinal");

                entity.Property(e => e.FoodImage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("foodImage");

                entity.Property(e => e.FoodMrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("foodMrp");

                entity.Property(e => e.FoodName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("foodName");

                entity.Property(e => e.FoodQuantity).HasColumnName("foodQuantity");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("place");

                entity.Property(e => e.RestaurantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("restaurantName");
            });

            modelBuilder.Entity<OrderTbl>(entity =>
            {
                entity.ToTable("OrderTbl");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lastName");

                entity.Property(e => e.Paymentmode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("paymentmode");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegisterTbl>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Register__1788CCACEC53AB6C");

                entity.ToTable("RegisterTbl");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
