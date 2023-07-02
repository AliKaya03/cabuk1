using Microsoft.EntityFrameworkCore;

namespace CabukWeb.Models
{
    public class Context:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D1JGSEG\\SQLEXPRESS; database=Cabuk.dbo; integrated security=true; TrustServerCertificate=true;");
        }

        public DbSet<Carts> Carts  { get; set; }
        public DbSet<Categories> Categories  { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments  { get; set; }
        public DbSet<Products> Products  { get; set; }
        public DbSet<Users> Users  { get; set; }
    }
}
