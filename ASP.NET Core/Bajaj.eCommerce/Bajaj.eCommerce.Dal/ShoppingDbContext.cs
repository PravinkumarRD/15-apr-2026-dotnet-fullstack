using Bajaj.eCommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bajaj.eCommerce.Dal;

public class ShoppingDbContext:DbContext
{
    public ShoppingDbContext()
    {
        
    }
    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options) :base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;Database=BajajEcomDbApr26;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
