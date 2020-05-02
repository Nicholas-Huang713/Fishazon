using Microsoft.EntityFrameworkCore;
 
namespace Fishazon.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<Product> Products {get;set;}
        public DbSet<Item> Items {get;set;}
        
    }
}