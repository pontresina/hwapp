// 23.12.2016 fwa created
// 27.12.2016 fwa Test git clone
// 17.01.2017 fwa
// https://weblog.west-wind.com/posts/2016/Jun/29/First-Steps-Exploring-NET-Core-and-ASPNET-Core#Wherearewe?

// vs code
// %USERPROFILE%
// C:\Users\[username]\.vscode\extensions
// C:\Users\[username]\AppData\Roaming\Code\User
// ..\hwapp\.vscode\settings.json
// C:\Users\nnn\AppData\Roaming\Code\User\settings.json

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
// IndexedDB

// Layout
// https://docs.microsoft.com/en-us/aspnet/core/mvc/views/layout#viewimports
// http://asp.net-hacker.rocks/2016/02/18/extending-razor-views.html
// Migrating From ASP.NET MVC to ASP.NET Core MVC
// http://aspnetcore.readthedocs.io/en/stable/migration/mvc.html
// https://www.tutorialspoint.com/asp.net_core/asp.net_core_quick_guide.htm

// MSBUILD : error MSB4025: The project file could not be loaded. Data at the root level is invalid. Line 1, position 1.
// https://github.com/aspnet/JavaScriptServices/issues/495

// Serving static files
// https://jonhilton.net/2016/08/25/how-to-serve-static-files-for-your-single-page-application-from-net-core/

// https://datatables.net/

// Node.js
// https://nodejs.org/en/

// jquery
// http://jquery.com/

// node -v
// npm -v

// ASP.NET -------------------------------------------------------------------------------------------------------
// ASP.NET Core – Schreiben von Apps mit Visual Studio Code und Entity Framework
// https://msdn.microsoft.com/de-de/magazine/mt767698.aspx
// ASP.NET Core & Visual Studio Code
// https://blog.5minds.de/asp-net-core-visual-studio-code/
// ASP.NET – Schreiben von sauberem Code in ASP.NET Core mit Abhängigkeitsinjektion (Dependency Injection)
// https://msdn.microsoft.com/de-de/magazine/mt703433.aspx
// Introduction to ASP.NET Core
// https://docs.microsoft.com/en-us/aspnet/core/
// Developers’ Home, Teil 2 - ASP.NET & Visual Studio Code auf Mac & Linux
// https://channel9.msdn.com/Series/DevelopersHome/Developers-Home-Teil-2-ASPNET--Visual-Studio-Code-auf-Mac--Linux
// Source code for 'Pro ASP.NET Core MVC' by Adam Freeman
// https://github.com/Apress/pro-asp.net-core-mvc

// http://electron.atom.io/
// http://ionicframework.com/
// http://www.typescriptlang.org/
// Die eigene Desktop-App mit Web-Technologien erstellen: Mit Electron von GitHub kein Problem
// http://t3n.de/news/electron-github-nodejs-chromium-656328/
// https://microsoft.github.io/monaco-editor/
// vs code C:\Program Files (x86)\Microsoft VS Code\resources\app\out\vs\workbench\electron-browser\bootstrap\index.html

// Windows 10: Ein Code, eine App – für alle Windows-Geräte
// https://entwickler.de/online/windowsdeveloper/windows-10-ein-code-eine-app-alle-windows-geraete-193131.html

// PWA
// http://www.biz-factory.de/2016/08/04/3-gruende-warum-progressive-web-apps-die-besseren-apps-sind/
// https://blog.oio.de/2016/06/10/ein-einblick-in-progressive-web-apps/
// https://flights.airberlin.com/de-DE/progressive-web-app

// Linux 
// Installing Visual Studio Code on Linux (Ubuntu)
// http://jochen.kirstaetter.name/blog/linux/install-visual-studio-code-on-linux-ubuntu.html
// .net Core unter Linux (Raspberry Pi)
// https://www.dotnet.xyz/tutorials/net-core-unter-linux-raspberry-pi/

// Variable divs
// http://jsfiddle.net/A8zLY/5/

// Wie man eine HTML5 Webseite aufbaut – Teil 1
// http://www.lingulo.com/de/tutorials-de/css-tutorials/how-to-build-a-html5-website-from-scratch

// Webentwicklung ohne JavaScript
// Bootstrap components using Bootleg.css
// http://labs.thecssninja.com/bootleg/index.html#
// 
// Bootstrap (Framework)
// https://de.wikipedia.org/wiki/Bootstrap_(Framework)
// 
// Bootstrap
// http://holdirbootstrap.de/



using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Http;

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
                    //.UseSetting("detailedErrors","true")
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
            //services.AddMvcCore();
            //services.AddLogging();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory)
        {
            //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            //loggerFactory.AddConsole();

            env.EnvironmentName = EnvironmentName.Production;

            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
            }

            //app.UseMvcWithDefaultRoute();

            app.UseStaticFiles();
            //app.UseMvc();
            app.UseMvc(routes =>
                        {
                            routes.MapRoute(
                                name: "default",
                                template: "{controller=simplesidebar}/{action=Index}/{id?}");
                        });
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Pre Processing");
            //    await next();
            //    await context.Response.WriteAsync("Post Processing");
            //});

            /*
            app.Use(async (context, next) =>
                {
                    await next();
                    if (context.Response.StatusCode == 500)
                    {
                        context.Request.Path = "~/Home"; 
                        await next();
                    }
                });
            */
            // Handler of last Resort
            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    "Hello World of the last resort. The Time is: " +
                    DateTime.Now.ToString("hh:mm:ss tt"));

            });
            */

            /*app.Use(async (context, next) =>
            {
                //context.HttpContext.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(
                    "Status code page, status code: " + 
                    context.Response.StatusCode);
            });*/

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
