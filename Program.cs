using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Openshift_tut 
    //https://blog.openshift.com/asp-net-openshift-part-5-models-mvc/
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var conf = new ConfigurationBuilder().AddEnvironmentVariables("").Build();
            var url = conf["ASPNETCORE_URLS"] ?? "http://*:8080";
            //
            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseIISIntegration()
                        .UseStartup<Startup>()//tut had "UseStartup()" which gave err
                        .UseUrls(url)
                        .Build();



            //CreateWebHostBuilder(args).Build();

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
