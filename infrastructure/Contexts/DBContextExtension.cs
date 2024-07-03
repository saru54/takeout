using commen;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Contexts
{
    public static class DBContextExtension
    {
        public static IServiceCollection AddMyDBContext(this IServiceCollection services)
        {
            var connectionString = AppSettingHelper.Configuration.GetConnectionString("Mysql");
            return services.AddDbContext<TakeoutDBContext>(opt =>
            {
                opt.UseMySql(connectionString,new MySqlServerVersion(new Version(8,3,0)));
            });
        }
    }
}
