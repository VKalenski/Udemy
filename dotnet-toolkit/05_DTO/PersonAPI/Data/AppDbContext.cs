#region Usings
using Microsoft.EntityFrameworkCore;
using PersonAPI.Models;
#endregion

namespace PersonAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<Person> People => Set<Person>();
    }
}