using Bloggy.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace Bloggy.Server.DB
{
    public class DatabaseContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Topic> Topics { get; set; }
    }
}
