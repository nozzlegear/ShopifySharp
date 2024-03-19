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
    /// <p>Note: Policies are not true middleware, ShopifySharp services can only use one policy at this time.</p>2
    /// </summary>
    /// <param name="lifetime">The lifetime of <see cref="IRequestExecutionPolicy"/>.</param>
    /// <typeparam name="T">A class that implements ShopifySharp's <see cref="IRequestExecutionPolicy"/> interface.</typeparam>
    public static IServiceCollection AddShopifySharpRequestExecutionPolicy<T>(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Singleton)
        where T : class, IRequestExecutionPolicy
    {
        services.Add(new ServiceDescriptor(typeof(IRequestExecutionPolicy), typeof(T), lifetime));
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
    /// <param name="lifetime">The lifetime of <see cref="IRequestExecutionPolicy"/>.</param>
    /// </summary>
    public static IServiceCollection AddShopifySharpUtilities(this IServiceCollection services, Action<ShopifySharpUtilityOptions>? configure = null, ServiceLifetime lifetime = ServiceLifetime.Singleton)
    {
        var options = new ShopifySharpUtilityOptions();
        configure?.Invoke(options);
        
        if(options.OauthUtility != null)
        {
            services.Add(new ServiceDescriptor(typeof(IShopifyOauthUtility), options.OauthUtility, lifetime));
        }
        else
        {
            services.TryAdd(new ServiceDescriptor(typeof(IShopifyOauthUtility), typeof(ShopifyOauthUtility), lifetime));
        }

        if(options.DomainUtility != null)
        {
            services.Add(new ServiceDescriptor(typeof(IShopifyDomainUtility), options.DomainUtility, lifetime));
        }
        else
        {
            services.TryAdd(new ServiceDescriptor(typeof(IShopifyDomainUtility), typeof(ShopifyDomainUtility), lifetime));
        }

        if(options.RequestValidationUtility != null)
        {
            services.Add(new ServiceDescriptor(typeof(IShopifyRequestValidationUtility), options.RequestValidationUtility, lifetime));
        }
        else
        {
            services.TryAdd(new ServiceDescriptor(typeof(IShopifyRequestValidationUtility), typeof(ShopifyRequestValidationUtility), lifetime));
        }

        return services;
    }

    /// <summary>
    /// Adds ShopifySharp's service factories to your Dependency Injection container. If you've added an <see cref="IRequestExecutionPolicy"/>,
    /// the service factories will use it when creating ShopifySharp services.
    /// <param name="lifetime">The lifetime of <see cref="IRequestExecutionPolicy"/>.</param>
    /// </summary>
    public static IServiceCollection AddShopifySharpServiceFactories(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Singleton)
    {
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
                services.TryAdd(new ServiceDescriptor(serviceType, type, lifetime));
            }
        }

        services.TryAdd(new ServiceDescriptor(typeof(IPartnerServiceFactory), typeof(PartnerServiceFactory), lifetime));

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
    /// <param name="lifetime">The lifetime of <see cref="IRequestExecutionPolicy"/>.</param>
    /// <typeparam name="T"></typeparam>
    public static IServiceCollection AddShopifySharp<T>(this IServiceCollection services, ServiceLifetime lifetime = ServiceLifetime.Singleton)
        where T : class, IRequestExecutionPolicy
    {
        return services
            .AddShopifySharpRequestExecutionPolicy<T>(lifetime: lifetime)
            .AddShopifySharpUtilities(lifetime: lifetime)
            .AddShopifySharpServiceFactories(lifetime: lifetime);
    }
}
