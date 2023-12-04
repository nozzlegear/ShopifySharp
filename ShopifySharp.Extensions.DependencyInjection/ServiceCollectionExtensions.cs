namespace ShopifySharp.Extensions.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;
using Factories;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddShopifySharp(this IServiceCollection services)
    {
        return services.AddFactories();
    }
}
