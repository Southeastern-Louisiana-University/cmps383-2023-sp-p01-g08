using Microsoft.EntityFrameworkCore;
using SP23.P01.Web.Data;

namespace SP23.P01.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer());
        }
    }
}
