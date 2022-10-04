using Microsoft.EntityFrameworkCore;

namespace Analytics.Models
{
    public class NumbersDbContext: DbContext
    {
        public NumbersDbContext(DbContextOptions<NumbersDbContext> options) : base(options)
        {
            
        }

        public DbSet<Numbers> Numbers { get; set; }
    }
}
