using Microsoft.EntityFrameworkCore;

namespace mmpos.Data
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
