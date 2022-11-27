using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IWebApplicationBuilder
    {
        public string[] Services { get; set; }
        public string Configuration { get; set; }
        WebApplication Build();
    }

    public class WebApplicationBuilder : IWebApplicationBuilder
    {
        readonly IHostBuilder _hostBuilder = new HostBuilder();

        public string[] Services { get; set; }
        public string Configuration { get; set; }

        public WebApplication Build()
        {
            _hostBuilder.ConfigureConfiguration(Configuration);
            _hostBuilder.ConfigureServices(Services);

            var webApplication = new WebApplication(_hostBuilder.Build());

            return webApplication;
        }
    }

    public class WebApplication
    {
        public readonly IHost Host;

        public WebApplication(IHost host)
        {
            Host = host;
        }
    }
}
