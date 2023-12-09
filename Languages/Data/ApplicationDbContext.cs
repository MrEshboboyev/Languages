using Languages.Models;
using Microsoft.EntityFrameworkCore;

namespace Languages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Language> Languages { get; set; }
    }
}
