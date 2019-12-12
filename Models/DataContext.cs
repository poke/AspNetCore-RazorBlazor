using Microsoft.EntityFrameworkCore;

namespace RazorBlazor.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Example> Examples
        { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}
    }
}
