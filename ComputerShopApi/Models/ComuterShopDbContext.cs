using Microsoft.EntityFrameworkCore;

namespace ComputerShopApi.Models
{
    public class ComuterShopDbContext : DbContext
    {
        public ComuterShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public ComuterShopDbContext()
        {
        }

        public DbSet<Osystem> Osystems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "server=localhost;database=computer;user=root;password=";

            optionsBuilder.UseMySql(conn,ServerVersion.AutoDetect(conn));
        }
    }
}
