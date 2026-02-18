using System;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Factories;
using ShopifySharp.Utilities;
using System.Reflection;
using System.Linq;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMethodReturnValue.Global

namespace ShopifySharp.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <param name="services">The service collection (DI container) to which the retry policy will be added.</param>
    extension(IServiceCollection services)
    {
        /// <summary>
        /// Adds a <see cref="IRequestExecutionPolicy"/> to your Dependency Injection container. ShopifySharp service factories
        /// managed by your container will use this policy when creating ShopifySharp services.
        /// <p>Note: Policies are not true middleware, ShopifySharp services can only use one policy at this time.</p>
        /// </summary>
        /// <param name="lifetime">The lifetime of <see cref="IRequestExecutionPolicy"/>.</param>
        /// <typeparam name="T">A class that implements ShopifySharp's <see cref="IRequestExecutionPolicy"/> interface.</typeparam>
        public IServiceCollection AddShopifySharpRequestExecutionPolicy<T>(ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where T : class, IRequestExecutionPolicy
        {
            if (typeof(T) == typeof(ExponentialRetryPolicy))
            {
                services.AddImplementationIfNotRegistered<ExponentialRetryPolicyOptions, ExponentialRetryPolicyOptions>(
                    _ => ExponentialRetryPolicyOptions.Default(),
                    lifetime);
            }
            services.Add(new ServiceDescriptor(typeof(IRequestExecutionPolicy), typeof(T), lifetime));
            return services;
        }

        /// <summary>
        /// Adds ShopifySharp's utilities to your Dependency Injection container. Includes the following utilities:
        /// <list type="bullet">
        /// <item><see cref="IShopifyOauthUtility"/></item>
        /// <item><see cref="IShopifyDomainUtility"/></item>
        /// <item><see cref="IShopifyRequestValidationUtility"/></item>
        /// <item><see cref="IShopifyGraphqlUtility"/></item>
        /// </list>
        /// <param name="configure">An optional configuration action for configuring the utilities.</param>
        /// <param name="lifetime">The lifetime of the ShopifySharp's utilities.</param>
        /// </summary>
        public IServiceCollection AddShopifySharpUtilities(Action<ShopifySharpUtilityOptions>? configure = null, ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            var options = new ShopifySharpUtilityOptions();
            configure?.Invoke(options);

            if(options.OauthUtility != null)
            {
                services.Add(new ServiceDescriptor(typeof(IShopifyOauthUtility), _ => options.OauthUtility, lifetime));
            }
            else
            {
                services.TryAdd(new ServiceDescriptor(typeof(IShopifyOauthUtility), typeof(ShopifyOauthUtility), lifetime));
            }

            if(options.DomainUtility != null)
            {
                services.Add(new ServiceDescriptor(typeof(IShopifyDomainUtility), _ => options.DomainUtility, lifetime));
            }
            else
            {
                services.TryAdd(new ServiceDescriptor(typeof(IShopifyDomainUtility), typeof(ShopifyDomainUtility), lifetime));
            }

            if(options.RequestValidationUtility != null)
            {
                services.Add(new ServiceDescriptor(typeof(IShopifyRequestValidationUtility), _ => options.RequestValidationUtility, lifetime));
            }
            else
            {
                services.TryAdd(new ServiceDescriptor(typeof(IShopifyRequestValidationUtility), typeof(ShopifyRequestValidationUtility), lifetime));
            }

            if (options.GraphqlSchemaUtility != null)
            {
                services.Add(new ServiceDescriptor(typeof(IShopifyGraphqlUtility), _ => options.GraphqlSchemaUtility, lifetime));
            }
            else
            {
                services.TryAdd(new ServiceDescriptor(typeof(IShopifyGraphqlUtility), typeof(ShopifyGraphqlUtility), lifetime));
            }

            return services;
        }

        /// <summary>
        /// Adds ShopifySharp's service factories to your Dependency Injection container. If you've added an <see cref="IRequestExecutionPolicy"/>,
        /// the service factories will use it when creating ShopifySharp services.
        /// </summary>
        /// <param name="lifetime">The lifetime of ShopifySharp's service factories.</param>
        public IServiceCollection AddShopifySharpServiceFactories(ServiceLifetime lifetime = ServiceLifetime.Singleton)
        {
            var assembly = Assembly.GetAssembly(typeof(IServiceFactory<>));

            var factoryTypes = assembly!.GetTypes()
                .Where(t => t is { IsAbstract: false, IsInterface: false })
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IServiceFactory<>)));

            foreach (var type in factoryTypes)
            {
                var serviceType = type
                    .GetInterfaces()
                    .FirstOrDefault(i => !i.IsGenericType);

                if (serviceType is null)
                    continue;

                // If the factory has a constructor that takes an IServiceProvider, use that one to construct it
                var ctor = type.GetConstructors()
                    .FirstOrDefault(c => c.GetParameters().Any(p => p.ParameterType == typeof(IServiceProvider)));

                services.TryAdd(ctor is not null
                    ? new ServiceDescriptor(serviceType, sp => ctor.Invoke([sp]), lifetime)
                    : new ServiceDescriptor(serviceType, type, lifetime));
            }

            services.TryAdd(new ServiceDescriptor(typeof(IPartnerServiceFactory), (sp) => new PartnerServiceFactory(sp), lifetime));

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
        /// <param name="lifetime">The lifetime of all ShopifySharp's Dependency Injection services</param>
        /// <typeparam name="T"></typeparam>
        public IServiceCollection AddShopifySharp<T>(ServiceLifetime lifetime = ServiceLifetime.Singleton)
            where T : class, IRequestExecutionPolicy
        {
            if (typeof(T) == typeof(ExponentialRetryPolicy))
            {
                services.AddImplementationIfNotRegistered<ExponentialRetryPolicyOptions, ExponentialRetryPolicyOptions>(
                    _ => ExponentialRetryPolicyOptions.Default(),
                    lifetime);
            }

            return services
                .AddShopifySharpRequestExecutionPolicy<T>(lifetime: lifetime)
                .AddShopifySharpUtilities(lifetime: lifetime)
                .AddShopifySharpServiceFactories(lifetime: lifetime);
        }

        /// <summary>
        /// Registers the interface and its implementation if they aren't already registered.
        /// </summary>
        private void AddImplementationIfNotRegistered<TService, TImplementation>(Func<IServiceProvider, TImplementation> factory, ServiceLifetime lifetime)
            where TImplementation : notnull, TService
        {
            services.TryAdd(new ServiceDescriptor(typeof(TService), (innerServices) =>
            {
                var output = factory.Invoke(innerServices);
                return output;
            }, lifetime));
        }
    }
}
