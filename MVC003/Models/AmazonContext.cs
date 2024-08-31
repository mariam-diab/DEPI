using Microsoft.EntityFrameworkCore;
using MVC003.Models;

namespace MVC_003.Models
{
    public class AmazonContext : DbContext
    {
        public AmazonContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Order> orders { get; set; }

    }
}
