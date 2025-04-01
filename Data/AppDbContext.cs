using Microsoft.EntityFrameworkCore;
using WebCRUD.Models;

namespace WebCRUD.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleada> Empleadas { get; set; }
    }
}
