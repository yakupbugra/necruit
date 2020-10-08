﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Necruit.Infrastructure.Persistence.Configurations;
using Necruit.Infrastructure.Persistence.Repository;

namespace Necruit.Application.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NecruitDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("NecruitConnection"),
            b => b.MigrationsAssembly(typeof(NecruitDbContext).Assembly.FullName)));

            services.AddScoped<DbContext>(provider => provider.GetService<NecruitDbContext>());
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>)); 
            
            return services;
        }
    }
}