using System.Data.Entity;

namespace WebApplicationNew.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<WTLs> WTLs { get; set; }
    }
}