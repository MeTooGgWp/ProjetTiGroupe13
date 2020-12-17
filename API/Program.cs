using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Models.FicheModel;
using ProjetctTiGr13;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        //retirer .useUrl si ça ne marche pas
    }
}