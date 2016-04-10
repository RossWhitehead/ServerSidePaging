using ServerSidePaging.Model;
using System.Data.Entity;

namespace ServerSidePaging.Data
{
    public class ServerSidePagingDbContext : DbContext
    {
        public ServerSidePagingDbContext() : base("DefaultConnection")
        { }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
