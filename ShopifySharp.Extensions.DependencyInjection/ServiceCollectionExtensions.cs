using System;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Factories;
using ShopifySharp.Utilities;
using System.Reflection;
using System.Linq;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace ShopifySharp.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds a <see cref="IRequestExecutionPolicy"/> to your Dependency Injection container. ShopifySharp service factories
    /// managed by your container will use this policy when creating ShopifySharp services.
    /// <p>Note: Policies are not true middleware, ShopifySharp services can only use one policy at this time.</p>
    /// </summary>
    /// <typeparam name="T">A class that implements ShopifySharp's <see cref="IRequestExecutionPolicy"/> interface.</typeparam>
    public static IServiceCollection AddShopifySharpRequestExecutionPolicy<T>(this IServiceCollection services)
        where T : class, IRequestExecutionPolicy
    {
        // TODO: add ServiceLifetime parameter
        services.AddSingleton<IRequestExecutionPolicy, T>();
        return services;
    }

    /// <summary>
    /// Adds ShopifySharp's utilities to your Dependency Injection container. Includes the following utilities:
    /// <list type="bullet">
    /// <item><see cref="IShopifyOauthUtility"/></item>
    /// <item><see cref="IShopifyDomainUtility"/></item>
    /// <item><see cref="IShopifyRequestValidationUtility"/></item>
    /// </list>
    /// <param name="configure">An optional configuration action for configuring the utilities.</param>
    /// </summary>
    public static IServiceCollection AddShopifySharpUtilities(this IServiceCollection services, Action<ShopifySharpUtilityOptions>? configure = null)
    {
        var options = new ShopifySharpUtilityOptions();
        configure?.Invoke(options);

        // TODO: add ServiceLifetime parameter
        if(options.OauthUtility != null)
        {
            services.AddSingleton(options.OauthUtility);
        }
        else
        {
            services.TryAddSingleton<IShopifyOauthUtility, ShopifyOauthUtility>();
        }

        if(options.DomainUtility != null)
        {
            services.AddSingleton(options.DomainUtility);
        }
        else
        {
            services.TryAddSingleton<IShopifyDomainUtility, ShopifyDomainUtility>();
        }

        if(options.RequestValidationUtility != null)
        {
            services.AddSingleton(options.RequestValidationUtility);
        }
        else
        {
            services.TryAddSingleton<IShopifyRequestValidationUtility, ShopifyRequestValidationUtility>();
        }

        return services;
    }

    /// <summary>
    /// Adds ShopifySharp's service factories to your Dependency Injection container. If you've added an <see cref="IRequestExecutionPolicy"/>,
    /// the service factories will use it when creating ShopifySharp services.
    /// </summary>
    public static IServiceCollection AddShopifySharpServiceFactories(this IServiceCollection services)
    {
        // TODO: add ServiceLifetime parameter
        var assembly = Assembly.GetAssembly(typeof(IServiceFactory<>));

        var factoryTypes = assembly!.GetTypes()
            .Where(t => !t.IsAbstract && !t.IsInterface)
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IServiceFactory<>)));

        foreach (var type in factoryTypes)
        {
            var serviceType = type.GetInterfaces()
                .Where(i => !i.IsGenericType)
                .FirstOrDefault();

            if(serviceType != null)
            {
                services.TryAddSingleton(serviceType, type);
            }
        }

        services.TryAddSingleton<IPartnerServiceFactory, PartnerServiceFactory>();

        return services;
    }

    /// <summary>
    /// Adds all of ShopifySharp's Dependency Injection services to your DI container. This is a convenience method and
    /// simply calls the following extensions sequentially:
    /// <list type="bullet">
    /// <item><see cref="AddShopifySharpRequestExecutionPolicy{T}"/></item>
    /// <item><see cref="AddShopifySharpUtilities"/></item>
    /// <item><see cref="AddShopifySharpServiceFactories"/></item>
    /// </list>
    /// </summary>
    /// <param name="services"></param>
    /// <typeparam name="T"></typeparam>
    public static IServiceCollection AddShopifySharp<T>(this IServiceCollection services)
        where T : class, IRequestExecutionPolicy
    {
        return services
            .AddShopifySharpRequestExecutionPolicy<T>()
            .AddShopifySharpUtilities()
            .AddShopifySharpServiceFactories();
    }
}
