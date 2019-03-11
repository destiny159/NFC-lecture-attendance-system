using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net;

namespace NFCSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            // .UseKestrel(options =>
            // {
            //     options.Listen(IPAddress.Loopback, 5000);
            //     options.Listen(IPAddress.Loopback, 5001, listenOptions =>
            //     {
            //         listenOptions.UseHttps("localhost.pfx", "password");
            //     });
            // })
                //.UseUrls("https://*:4430")
                .UseUrls("http://*:4430")
                .UseStartup<Startup>();
    }
}
