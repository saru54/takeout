using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commen
{
    public class AppSettingHelper
    {
        public static IConfiguration Configuration { get; set; }
        static AppSettingHelper()
        {
            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource { Path = "appsetting.json", ReloadOnChange = true })
                .Build();
        }
    }
}
