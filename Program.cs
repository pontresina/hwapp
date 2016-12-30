// 23.12.2016 fwa created
// 27.12.2016 fwa Test git clone
// https://weblog.west-wind.com/posts/2016/Jun/29/First-Steps-Exploring-NET-Core-and-ASPNET-Core#Wherearewe?

// vs code
// %USERPROFILE%
// C:\Users\[username]\.vscode\extensions
// C:\Users\[username]\AppData\Roaming\Code\User

// Debugging 
// https://code.visualstudio.com/Docs/editor/debugging

// dotnet
// .NET-Dokumentation
// https://docs.microsoft.com/de-de/dotnet/
// 1.0.0-preview2-003121
// 1.0.0-preview2-003131
// 1.0.0-preview3-004056
// dotnet publish -o site

// "C:\Program Files\dotnet\dotnet.exe" exec --additionalprobingpath C:\Users\Frank\.nuget\packages C:\_Store\Repos2\hwapp\bin\Debug\netcoreapp1.0\hwapp.dll

// git
// git config --global http.proxy http://user:pwd@d100apap-by07.proxy.intern:3128
// git config --global http.proxy http://proxyuser:proxypwd@proxy.server.com:8080
// git config --global --unset http.proxy
// git config --global --get http.proxy

// http://sqlitebrowser.org/

// Layout
// https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout#viewimports
// http://asp.net-hacker.rocks/2016/02/18/extending-razor-views.html
// Migrating From ASP.NET MVC to ASP.NET Core MVC
// http://aspnetcore.readthedocs.io/en/stable/migration/mvc.html
// https://www.tutorialspoint.com/asp.net_core/asp.net_core_quick_guide.htm

// MSBUILD : error MSB4025: The project file could not be loaded. Data at the root level is invalid. Line 1, position 1.
// https://github.com/aspnet/JavaScriptServices/issues/495

using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool IsConsole = false;

            if(args.Length != 0)
            {
                if(args[0] == "--console")
                {
                    Console.Clear();
                    Console.WriteLine("Console true");
                    IsConsole=true;
                    Console.ReadLine();
                }
            }

            if(IsConsole == false){
                    /*.UseServer("Microsoft.AspNetCore.Server.Kestrel")
                    .UseApplicationBasePath(Directory.GetCurrentDirectory())
                    .UseDefaultConfiguration(args)
                    .UseIISPlatformHandlerUrl()
                    .UseUrls("http://localhost:5050")*/

                var host = new WebHostBuilder()
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseKestrel()
                    //.UseIISIntegration()
                    .UseStartup<Startup>()
                    .UseUrls("http://localhost:5001")
                    .Build();

                host.Run();
            }
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
            }

            //app.UseMvc();
            app.UseMvc(routes =>
                        {
                            routes.MapRoute(
                                name: "default",
                                template: "{controller=Home}/{action=Index}/{id?}");
                        });
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Pre Processing");
            //    await next();
            //    await context.Response.WriteAsync("Post Processing");
            //});

            // Handler of last Resort
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    "Hello World of the last resort. The Time is: " +
                    DateTime.Now.ToString("hh:mm:ss tt"));

            });

        }
    }

    public class HelloWorldController : Controller
    {
        [HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new
            {
                message = "Hello World",
                time = DateTime.Now
            };
        }

        [HttpGet("helloworld")]
        public ActionResult HelloworldMvc()
        {
            ViewBag.Message = "Hello world!";
            ViewBag.Time = DateTime.Now;

            //return View("helloworld");
            return View("~/helloworld.cshtml");
        }
    }
}
