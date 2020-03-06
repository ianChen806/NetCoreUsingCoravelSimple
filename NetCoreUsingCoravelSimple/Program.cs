using Coravel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NetCoreUsingCoravelSimple.Invocable;

namespace NetCoreUsingCoravelSimple
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                       .ConfigureWebHostDefaults(webBuilder =>
                       {
                           webBuilder.UseStartup<Startup>();
                       });
        }

        public static void Main(string[] args)
        {
            var build = CreateHostBuilder(args).Build();
            build.Services.UseScheduler(scheduler =>
            {
                scheduler.Schedule<MyInvocable>()
                         .EverySeconds(10);
                         
            });
            build.Run();
        }
    }
}