using Microsoft.EntityFrameworkCore;
using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<CovidLog> covidLogs { get; set; }

    }
}
