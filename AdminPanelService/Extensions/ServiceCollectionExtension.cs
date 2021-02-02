using AdminPanelService.Data;
using AdminPanelService.Models;
using AdminPanelService.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanelService.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddUserService(this IServiceCollection services)
            => services.AddTransient<UserService>();

        public static IServiceCollection AddRepasitoryService(this IServiceCollection services)
            => services.AddScoped<Repasitory<User>>();

        public static IServiceCollection AddresultBuilderService(this IServiceCollection services)
            => services.AddSingleton<IResultBuilder, ResultBuilderService>();

        public static IServiceCollection AddImageService(this IServiceCollection services)
            => services.AddTransient<ImageService>();
    }
}
