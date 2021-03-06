﻿// 23.12.2016 fwa created
// 27.12.2016 fwa Test git clone
// 20.01.2017 fwa
// http://localhost:5001
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
// http://www.w3schools.com/bootstrap/default.asp
// Timeline http://codepen.io/bsngr/pen/Ifvbi 
// http://www.designbootstrap.com/livedemos/2015/03/02/side-menu/index.html#
// https://www.tutorialspoint.com/bootstrap/bootstrap_tables.htm
// https://getbootstrap.com/examples/dashboard/#
// Sidebar https://medium.com/wdstack/bootstrap-sidebar-examples-e363021395ff#.xxmblsoy7
// http://www.bootply.com/dragan/3AZB0lGFyt
// toggle http://seegatesite.com/create-simple-cool-sidebar-menu-with-bootstrap-3/
// http://bootsnipp.com/snippets/4zmQ

// Listener or timer  Variable changed
// https://www.daniweb.com/programming/software-development/threads/215395/detect-variable-change
// https://social.msdn.microsoft.com/Forums/vstudio/en-US/8a7aa410-3c89-4860-a9ff-1d9733629873/is-there-a-listener-to-detect-change-in-variable?forum=csharpgeneral

using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Logging;
// using Microsoft.AspNetCore.Http;

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

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel
            // https://github.com/aspnet/KestrelHttpServer/blob/dev/samples/SampleApp/Startup.cs
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/hosting
            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/app-state
            // https://books.google.de/books?id=iEQWDQAAQBAJ&pg=PA405&lpg=PA405&dq=internal.webhost%C2%A0core&source=bl&ots=tJ_N8iI6gr&sig=nsiqrcBMlRymCptvxi6Ghambkc4&hl=de&sa=X&ved=0ahUKEwib7arp1dbRAhVEJ5oKHRfoBHwQ6AEIKTAB#v=onepage&q=internal.webhost%C2%A0core&f=false
            // http://www.csharpstar.com/asp-net-core-as-a-console-application/

            if(IsConsole == false){
                    /*.UseServer("Microsoft.AspNetCore.Server.Kestrel")
                    .UseApplicationBasePath(Directory.GetCurrentDirectory())
                    .UseDefaultConfiguration(args)
                    .UseIISPlatformHandlerUrl()
                    .UseUrls("http://localhost:5050")*/

                var host = new WebHostBuilder()
                    .UseEnvironment("Development")
                    .CaptureStartupErrors(true)
                    .UseSetting("detailedErrors","true")
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseKestrel()
                    //.UseIISIntegration()
                    .UseStartup<Startup>()
                    .UseUrls("http://localhost:5001")
                    .Build();
                
                Console.WriteLine("host.start");

                host.Start();
                //host.Run();

                using (host)
                {
                    // http://stackoverflow.com/questions/5891538/listen-for-key-press-in-net-console-app
                    // https://blog.mariusschulz.com/2016/08/06/simulating-latency-in-asp-net-core
                    // .NET Core API Reference
                    // https://docs.microsoft.com/en-us/dotnet/core/api/
                    // Websocket
                    // http://zbrad.github.io/tools/wscore/
                    // ASP.NET Core - Teil 1: die Basics
                    // https://schwabencode.com/blog/asp-net/2016/09/05/asp-net-core-die-basics/
                    // c# listener change variable
                    // http://stackoverflow.com/questions/24203952/trigger-an-event-when-a-variable-value-changes

                    /*System.Threading.ThreadStart threadStart = delegate { SomeMethod(variable); };

                    System.Threading.Thread thread = new System.Threading.Thread(threadStart);
                    thread.IsBackground = true;
                    thread.Start();*/

                    Console.WriteLine("Press ESC to stop");

                    while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
                    {
                        // do something
                        Console.WriteLine(DateTime.Now);
                    }   

                    /*
                    Console.WriteLine("... Press escape, a, then control X");
                    // Call ReadKey method and store result in local variable.
                    // ... Then test the result for escape.
                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("You pressed escape!");
                    }
                    // Call ReadKey again and test for the letter a.
                    info = Console.ReadKey();
                    if (info.KeyChar == 'a')
                    {
                        Console.WriteLine("You pressed a");
                    }
                    // Call ReadKey again and test for control-X.
                    // ... This implements a shortcut sequence.
                    info = Console.ReadKey();
                    if (info.Key == ConsoleKey.X &&
                        info.Modifiers == ConsoleModifiers.Control)
                    {
                        Console.WriteLine("You pressed control X");
                    }      
                    */          
                }
            }
        }
    }

    public class Startup
    {
        public string applicationPath = "";
        public string contentRootPath = "";
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddMvcCore();
            //services.AddLogging();

        // Adds a default in-memory implementation of IDistributedCache.
        /*services.AddDistributedMemoryCache();

        services.AddSession(options =>
        {
            // Set a short timeout for easy testing.
            options.IdleTimeout = TimeSpan.FromSeconds(10);
            options.CookieHttpOnly = true;
        });*/
            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Microsoft.Extensions.Logging.ILoggerFactory loggerFactory)
        {
            //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
            //loggerFactory.AddConsole();

            env.EnvironmentName = EnvironmentName.Development;
            applicationPath = env.WebRootPath;
            contentRootPath = env.ContentRootPath;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
                                template: "{controller=Toggle}/{action=Index}/{id?}");
                        });

            //app.UseSession();
                        
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

        /*public static void StartBackgroundThread(System.Threading.ThreadStart threadStart)
        {
          if (threadStart != null)
          {
            System.Threading.ThreadStart thread = new System.Threading.ThreadStart(threadStart);
            //thread.IsBackground = true;
            //thread.Start();
          }
        }*/
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
