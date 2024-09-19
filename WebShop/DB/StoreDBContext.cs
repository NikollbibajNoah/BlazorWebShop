using Microsoft.EntityFrameworkCore;
using WebShop.Model;

namespace WebShop.DB
{
    public class StoreDBContext : DbContext
    {
        public DbSet<ItemData> StoreItems { get; set; }

        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options)
        { 
        
        }
    }
}
