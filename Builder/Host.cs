using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IHostBuilder
    {
        Host Build();
        void ConfigureServices(string[] services);
        void ConfigureConfiguration(string configuration);
    }

    public class HostBuilder : IHostBuilder
    {
        readonly Host host = new Host();
        public Host Build()
        {
            return host;
        }

        public void ConfigureConfiguration(string configuration)
        {
            host.Configuration = configuration;
        }

        public void ConfigureServices(string[] services)
        {
            host.Services = services;
        }
    }

    public interface IHost
    {
        string[] Services { get; set; }
        string Configuration { get; set; }
    }

    public class Host:IHost
    {
        public string[] Services { get; set; }
        public string Configuration { get; set; }
    }
}
