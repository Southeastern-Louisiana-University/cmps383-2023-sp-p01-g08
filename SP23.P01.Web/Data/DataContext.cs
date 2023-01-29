using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SP23.P01.Web.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
              
        }

        public DbSet<TrainStations> TrainStations { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*
             * Replace "." with IP of remote DB where "Server=."
             * Replace *placeholder* with name of DB
             */
            optionsBuilder.UseSqlServer("Server=.;Database=*placeholder*;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
