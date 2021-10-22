using Data;
using GenericRepository.Interdace;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRPanel.Utility
{
    public static class EFEXtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services , string connectionStiring)
        {
            services.AddDbContext<MRPanelContext>(options => options.UseSqlServer(connectionStiring, x => x.MigrationsAssembly("MovieDB")));
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
