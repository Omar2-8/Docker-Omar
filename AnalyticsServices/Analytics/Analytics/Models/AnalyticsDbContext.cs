using Microsoft.EntityFrameworkCore;

namespace Analytics.Models
{
    public class AnalyticsDbContext : DbContext
    {
        public AnalyticsDbContext(DbContextOptions<AnalyticsDbContext> options) : base(options)
        {
            
        }

        public DbSet<Analytics> Analytics { get; set; }
    }
}
