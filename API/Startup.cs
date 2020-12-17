using API;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models.FicheModel;
using ProjetctTiGr13.Domain;
using ProjetctTiGr13.Domain.FicheComponent;
using ProjetctTiGr13.Helpers;
using ProjetctTiGr13.Services;

namespace ProjetctTiGr13
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            
            // configure strongly typed settings object
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            // configure DI for application services
            services.AddScoped<IUserService, UserService>();
    
            //Configure entityFrameWork in lazy Loading
            services.AddControllers();
            services.AddDbContext<db_fiche_persoContext>(options =>
                options.UseLazyLoadingProxies()
                    .UseSqlServer("Server=db-fiche-perso.database.windows.net,1433;Database=db_fiche_perso;User Id=louispoulet;Password=ProjetGroupe13"));
            
            
            
            //Configure automapper
            
          /*  var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddMvc();*/





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // global cors policy
            app.UseCors(x => x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseMiddleware<JwtMiddleware>();
            app.UseAuthentication();
            app.UseAuthorization();
            
            //custom jwt auth middleware
            

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}