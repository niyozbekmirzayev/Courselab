﻿using EduCenterWebAPI.Data.IRepositories;
using EduCenterWebAPI.Data.Respositories;
using Microsoft.Extensions.DependencyInjection;

namespace Courselab.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
