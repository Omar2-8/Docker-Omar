using Microsoft.EntityFrameworkCore;

namespace Enter_Data_BackEnd.Models
{
    public class NumbersDbContext: DbContext
    {
        public NumbersDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Numbers> Numbers { get; set; }
    }
}
