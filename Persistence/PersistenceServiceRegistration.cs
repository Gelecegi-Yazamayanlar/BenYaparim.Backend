using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using Persistence.Contexts;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory()));
            //Console.WriteLine(Directory.GetCurrentDirectory());
            configurationManager.AddJsonFile("appsettings.json");

            services.AddDbContext<BenYaparimDbContext>(options => options.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserRepository, EfUserRepository>();


            return services;
        }
    }
}
