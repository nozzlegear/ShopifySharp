#nullable enable
using System;
using System.Linq;

namespace ShopifySharp.Infrastructure;

internal static class InternalDependencyContainerConsolidation
{
    public static TService GetServiceOrDefault<TService, TDefault>(IDependencyContainer? container)
        where TDefault : TService
    {
        var service = container != null ? container.TryGetService<TService>() : default;

        if (service is not null)
            return service;

        // If the service isn't available in the container, try to resolve dependencies for TDefault
        var constructor = typeof(TDefault).GetConstructors().FirstOrDefault();
        if (constructor == null)
            throw new InvalidOperationException($"No public constructor found for type {typeof(TDefault)}.");

        var parameters = constructor.GetParameters()
            .Select(p => container?.TryGetService(p.ParameterType) ?? throw new InvalidOperationException($"Unable to resolve dependency for {p.ParameterType} required by {typeof(TDefault)}"))
            .ToArray();

        // Create an instance of TDefault using resolved parameters
        return (TService)constructor.Invoke(parameters);
    }

    public static TService GetServiceOrDefault<TService>(IDependencyContainer? container, TService @default)
    {
        var service = container != null ? container.TryGetService<TService>() : default;
        return service ?? @default;
    }
}
