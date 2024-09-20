using Microsoft.EntityFrameworkCore;
using Mirxes_Backend.Entities;

namespace Mirxes_Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Outliers> Outliers { get; set; }
        public DbSet<RawMaterials> RawMaterials { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
