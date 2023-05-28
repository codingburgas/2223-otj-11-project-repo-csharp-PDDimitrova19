using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using sms.dal.Models;

namespace sms.dal.Data;

public partial class StoreManagementSystemContext : DbContext
{
    public StoreManagementSystemContext()
    {
    }

    public StoreManagementSystemContext(DbContextOptions<StoreManagementSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog=StoreManagementSystem; Encrypt=false; Trusted_Connection=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC0711737B3A");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC07AFFC30A1");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductC__3214EC071D76AC83");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategories).HasConstraintName("FK__ProductCa__Categ__5441852A");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCategories).HasConstraintName("FK__ProductCa__Produ__534D60F1");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Store__3214EC07ADFF591D");

            entity.HasOne(d => d.Product).WithMany(p => p.Stores).HasConstraintName("FK__Store__ProductId__4D94879B");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07698B7B6F");

            entity.HasOne(d => d.Store).WithMany(p => p.Users).HasConstraintName("FK__Users__StoreId__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
