using AdminPanelService.Data;
using AdminPanelService.Models;
using AdminPanelService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AdminPanelService.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddUserService(this IServiceCollection services)
            => services.AddTransient<UserService>();

        public static IServiceCollection AddRepasitoryService(this IServiceCollection services)
        {
            services.AddScoped<Repasitory<User>>();
            services.AddScoped<Repasitory<Product>>();
            return services;
        }

        public static IServiceCollection AddresultBuilderService(this IServiceCollection services)
            => services.AddSingleton<IResultBuilder, ResultBuilderService>();

        public static IServiceCollection AddImageService(this IServiceCollection services)
            => services.AddTransient<ImageService>();

        public static IServiceCollection AddProductService(this IServiceCollection services)
            => services.AddTransient<ProductService>();
    }
}
