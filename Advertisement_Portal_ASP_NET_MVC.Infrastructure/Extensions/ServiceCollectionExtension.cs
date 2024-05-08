using Advertisement_Portal_ASP_NET_MVC.Domain.Interfaces;
using Advertisement_Portal_ASP_NET_MVC.Infrastructure.Persistance;
using Advertisement_Portal_ASP_NET_MVC.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Database>(options => options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection")));

            services.AddScoped<IMenageObjectRepository,MenageObjectRepository>();
        }
    }
}
