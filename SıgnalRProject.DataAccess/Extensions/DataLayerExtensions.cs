using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SıgnalRProject.DataAccess.Context;
using SıgnalRProject.DataAccess.Repositories.Abstract;
using SıgnalRProject.DataAccess.Repositories.Concrete;
using SıgnalRProject.DataAccess.UnıtOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.DataAccess.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<SıgnalRContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IUnıtOfWork, UnitOfWork>();

            return services;


        }
    }
}
