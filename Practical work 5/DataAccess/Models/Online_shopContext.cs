﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class Online_shopContext : DbContext
    {
        public Online_shopContext()
        {
        }

        public Online_shopContext(DbContextOptions<Online_shopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrdersStatus> OrdersStatuses { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<SpecProduct> SpecProducts { get; set; } = null!;
        public virtual DbSet<Specification> Specifications { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersRole> UsersRoles { get; set; } = null!;

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.IdCart)
                    .HasName("PK__Carts__54938089EEA7A415");

                entity.Property(e => e.IdCart)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_cart");

                entity.Property(e => e.CartDate)
                    .HasColumnType("date")
                    .HasColumnName("Cart_date");

                entity.Property(e => e.IdProd).HasColumnName("Id_prod");

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.ProdCount).HasColumnName("Prod_count");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("PK__Categori__4E840CE5168E0E5D");

                entity.Property(e => e.IdCategory)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_category");

                entity.Property(e => e.IdSpecification).HasColumnName("Id_specification");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(50)
                    .HasColumnName("Name_category");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("PK__Orders__33F95B5C9CD2C543");

                entity.Property(e => e.IdOrder)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_order");

                entity.Property(e => e.IdProd).HasColumnName("Id_prod");

                entity.Property(e => e.IdStatus).HasColumnName("Id_status");

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("Order_date");

                entity.Property(e => e.ProdCount).HasColumnName("Prod_count");
            });

            modelBuilder.Entity<OrdersStatus>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Orders_S__9D83DA2AEC11BCD2");

                entity.ToTable("Orders_Status");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_status");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.OrdersStatus1)
                    .HasMaxLength(40)
                    .HasColumnName("Orders_status");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProd)
                    .HasName("PK__Products__5FFE1E8EB1E2286E");

                entity.Property(e => e.IdProd)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_prod");

                entity.Property(e => e.IdCategory).HasColumnName("Id_category");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ProdCount).HasColumnName("Prod_count");

                entity.Property(e => e.ProdDescription)
                    .HasMaxLength(100)
                    .HasColumnName("Prod_description");
            });

            modelBuilder.Entity<SpecProduct>(entity =>
            {
                entity.HasKey(e => e.IdSpecProduct)
                    .HasName("PK__Spec_pro__8EE4795589FE2179");

                entity.ToTable("Spec_products");

                entity.Property(e => e.IdSpecProduct)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_spec_product");

                entity.Property(e => e.IdProd).HasColumnName("Id_prod");

                entity.Property(e => e.IdSpecification).HasColumnName("Id_specification");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.SpecValue).HasColumnName("Spec_value");
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.HasKey(e => e.IdSpecification)
                    .HasName("PK__Specific__E5171905E05BAD1A");

                entity.Property(e => e.IdSpecification)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_specification");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.NameSpec)
                    .HasMaxLength(50)
                    .HasColumnName("Name_spec");

                entity.Property(e => e.SpecValue).HasColumnName("Spec_value");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Users__B607F2489A4FBC29");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_user");

                entity.Property(e => e.IdRole).HasColumnName("Id_role");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.RegDate)
                    .HasColumnType("date")
                    .HasColumnName("Reg_date");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(40)
                    .HasColumnName("User_Login");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(40)
                    .HasColumnName("User_password");
            });

            modelBuilder.Entity<UsersRole>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__Users_ro__46CA8DBE9D0570E7");

                entity.ToTable("Users_roles");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_role");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_deleted");

                entity.Property(e => e.NameRole)
                    .HasMaxLength(40)
                    .HasColumnName("Name_role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
