using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using week5.Models;

namespace week5.Data;

public class UserContext : IdentityDbContext<AppUser>
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    public DbSet<Store> Stores { get; set; } = null!;

    public DbSet<Book> Books { get; set; } = null!;

    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //builder.Entity<AppUser>()
        //    .HasOne<Store>(au => au.Store)
        //    .WithOne(st => st.User)
        //    .HasForeignKey<Store>(au => au.UserId);

        //builder.Entity<Store>()
        //    .HasMany(s => s.Books)
        //    .WithOne(b => b.Store)
        //    .HasForeignKey(b => b.StoreId)
        //    .OnDelete(DeleteBehavior.Cascade);

        //builder.Entity<Order>()
        //    .HasOne<AppUser>(o => o.User)
        //    .WithMany(u => u.Orders)
        //    .HasForeignKey(o => o.UserId);

        //builder.Entity<OrderDetail>()
        //    .HasKey(od => new {od.OrderId, od.BookIsbn});

        //builder.Entity<OrderDetail>()
        //      .HasOne<Order>(od => od.Order)
        //      .WithMany(or => or.OrderDetails)
        //      .HasForeignKey(od => od.OrderId);

        //builder.Entity<OrderDetail>()
        //    .HasOne<Book>(od => od.Book)
        //    .WithMany(b => b.OrderDetails)
        //    .HasForeignKey(od => od.BookIsbn);

    }
}
