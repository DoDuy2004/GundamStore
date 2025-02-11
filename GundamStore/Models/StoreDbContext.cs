using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GundamStore.Models;

public partial class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<DetailOrder> DetailOrders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsImage> ProductsImages { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Slideshow> Slideshows { get; set; }

    public virtual DbSet<WebsiteInfo> WebsiteInfos { get; set; }

    public virtual DbSet<Wishlist> Wishlist { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=OmegaShopConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            // Đổi tên bảng
            entity.ToTable("accounts");

            // Thuộc tính CreatedAt (vì Data Annotations không hỗ trợ SQL Default)
            entity.Property(e => e.CreatedAt)
                  .HasDefaultValueSql("GETDATE()")
                  .HasColumnType("datetime")
                  .HasColumnName("created_at");

            // Cấu hình khóa ngoại đến bảng Roles
            entity.HasOne(e => e.Role)
                  .WithMany(r => r.Accounts)
                  .HasForeignKey(e => e.RoleId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_accounts_roles");

            // Cấu hình quan hệ một-nhiều với Order
            entity.HasMany(a => a.Orders)
                .WithOne(o => o.Account)
                .HasForeignKey(o => o.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình quan hệ một-nhiều với Wishlist
            entity.HasMany(a => a.Wishlists)
                .WithOne(w => w.Account)
                .HasForeignKey(w => w.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

        });

        modelBuilder.Entity<Blog>(entity =>
        {
            // Đổi tên bảng
            entity.ToTable("blogs");

            // Cấu hình kiểu dữ liệu cho ListContent, ShortContent, Content
            entity.Property(e => e.ListContent)
                  .HasColumnType("ntext")
                  .HasColumnName("listcontent");

            entity.Property(e => e.ShortContent)
                  .HasColumnType("ntext")
                  .HasColumnName("shortcontent");

            entity.Property(e => e.Content)
                  .HasColumnType("ntext")
                  .HasColumnName("content");

            // Cấu hình CreatedAt với giá trị mặc định
            entity.Property(e => e.CreatedAt)
                  .HasDefaultValueSql("GETDATE()")
                  .HasColumnType("datetime")
                  .HasColumnName("created_at");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            // Đổi tên bảng
            entity.ToTable("categories");

            // Định nghĩa khóa ngoại với bảng Products
            entity.HasMany(e => e.Products)
                  .WithOne(p => p.Category)
                  .HasForeignKey(p => p.CategoryId)
                  .HasConstraintName("FK_products_categories_categories");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            // Đổi tên bảng
            entity.ToTable("contacts");

            // Cấu hình CreatedAt với giá trị mặc định
            entity.Property(e => e.CreatedAt)
                  .HasDefaultValueSql("(getdate())")
                  .HasColumnType("datetime")
                  .HasColumnName("created_at");
        });


        modelBuilder.Entity<DetailOrder>(entity =>
        {
            // Đổi tên bảng
            entity.ToTable("detail_orders");

            // Cấu hình khóa chính kép (OrderId + ProductId)
            entity.HasKey(e => new { e.OrderId, e.ProductId });

            // Thiết lập quan hệ với bảng Order
            entity.HasOne(d => d.Order)
                  .WithMany(p => p.DetailOrders)
                  .HasForeignKey(d => d.OrderId)
                  .HasConstraintName("FK_detail_orders_orders")
                  .OnDelete(DeleteBehavior.Cascade);

            // Thiết lập quan hệ với bảng Product
            entity.HasOne(d => d.Product)
                  .WithMany(p => p.DetailOrders)
                  .HasForeignKey(d => d.ProductId)
                  .HasConstraintName("FK_detail_orders_products")
                  .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            // Đổi tên bảng
            entity.ToTable("orders");

            // Cấu hình CreatedAt với giá trị mặc định từ SQL
            entity.Property(e => e.CreatedAt)
                  .HasDefaultValueSql("(getdate())")
                  .HasColumnType("datetime")
                  .HasColumnName("created_at");

            // Quan hệ với Account (Một Account có nhiều Order)
            entity.HasOne(o => o.Account)
                  .WithMany(a => a.Orders)
                  .HasForeignKey(o => o.AccountId)
                  .OnDelete(DeleteBehavior.Cascade);

            // Quan hệ với DetailOrders (Một Order có nhiều DetailOrders)
            entity.HasMany(e => e.DetailOrders)
                  .WithOne(d => d.Order)
                  .HasForeignKey(d => d.OrderId)
                  .HasConstraintName("FK_detail_orders_orders")
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            // Tên bảng
            entity.ToTable("products");

            // Cấu hình CreatedAt với giá trị mặc định là ngày giờ hiện tại
            entity.Property(e => e.CreatedAt)
                  .HasDefaultValueSql("(getdate())")
                  .HasColumnType("datetime")
                  .HasColumnName("created_at");

            // Thiết lập quan hệ với bảng Category (một Product thuộc một Category)
            entity.HasOne(e => e.Category)
                  .WithMany(c => c.Products)
                  .HasForeignKey(e => e.CategoryId)
                  .HasConstraintName("FK_products_categories")
                  .OnDelete(DeleteBehavior.Cascade);

            // Thiết lập quan hệ với bảng DetailOrder
            entity.HasMany(e => e.DetailOrders)
                  .WithOne(d => d.Product)
                  .HasForeignKey(d => d.ProductId)
                  .HasConstraintName("FK_detail_orders_products");

            // Quan hệ với bảng ProductsImage
            entity.HasMany(e => e.ProductsImages)
                  .WithOne(p => p.Product)
                  .HasForeignKey(p => p.ProductId)
                  .HasConstraintName("FK_products_images_products");

            // Quan hệ với bảng Review
            entity.HasMany(e => e.Reviews)
                  .WithOne(r => r.Product)
                  .HasForeignKey(r => r.ProductId)
                  .HasConstraintName("FK_reviews_products");

            // Quan hệ với bảng Wishlist
            entity.HasMany(p => p.Wishlists)
                  .WithOne(w => w.Product)
                  .HasForeignKey(w => w.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ProductsImage>(entity =>
        {
            // Định nghĩa khóa chính với 2 cột (ProductId, Image)
            entity.HasKey(e => new { e.ProductId, e.Image });

            // Thiết lập quan hệ với Product (một Product có nhiều ProductsImage)
            entity.HasOne(e => e.Product)
                  .WithMany(p => p.ProductsImages)
                  .HasForeignKey(e => e.ProductId)
                  .HasConstraintName("FK_products_images_products")
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Wishlist>(entity =>
        {
            // Tên bảng
            entity.ToTable("wishlists");

            // Cấu hình khóa chính hợp nhất: kết hợp ProductId và AccountId tạo thành khóa chính
            entity.HasKey(e => new { e.ProductId, e.AccountId });

            // Cấu hình mối quan hệ với Product
            entity.HasOne(e => e.Product)  // Mỗi Wishlist có một Product
                .WithMany(p => p.Wishlists)  // Một Product có thể có nhiều Wishlist
                .HasForeignKey(e => e.ProductId)  // Cấu hình khóa ngoại với ProductId
                .OnDelete(DeleteBehavior.Cascade);  // Nếu xóa Product, xóa các Wishlist liên quan

            // Cấu hình mối quan hệ với Account
            entity.HasOne(e => e.Account)  // Mỗi Wishlist có một Account
                .WithMany(a => a.Wishlists)  // Một Account có thể có nhiều Wishlist
                .HasForeignKey(e => e.AccountId)  // Cấu hình khóa ngoại với AccountId
                .OnDelete(DeleteBehavior.Cascade);  // Nếu xóa Account, xóa các Wishlist liên quan
        });

        modelBuilder.Entity<Role>(entity =>
        {
            // Tên bảng
            entity.ToTable("roles");

            // Thiết lập quan hệ với bảng Account
            entity.HasMany(e => e.Accounts)
                  .WithOne(a => a.Role)
                  .HasForeignKey(a => a.RoleId)
                  .HasConstraintName("FK_accounts_roles");
        });

        modelBuilder.Entity<Slideshow>(entity =>
        {
            // Tên bảng
            entity.ToTable("slideshows");
        });

        modelBuilder.Entity<WebsiteInfo>(entity =>
        {
            // Tên bảng
            entity.ToTable("website_info");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            // Tên bảng
            entity.ToTable("reviews");

            // Định nghĩa khóa chính với 2 cột (ProductId, Email)
            entity.HasKey(e => new { e.ProductId, e.Email });

            // Thiết lập giá trị mặc định cho Rating
            entity.Property(e => e.Rating)
                  .HasDefaultValue(1);

            // Thiết lập quan hệ với Product (một Product có nhiều Review)
            entity.HasOne(e => e.Product)
                  .WithMany(p => p.Reviews)
                  .HasForeignKey(e => e.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
