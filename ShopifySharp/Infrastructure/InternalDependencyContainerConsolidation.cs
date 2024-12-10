#nullable enable
using System;
using System.Linq;

namespace ShopifySharp.Infrastructure;

internal static class InternalDependencyContainerConsolidation
{
    public static TService GetServiceOrDefault<TService>(IDependencyContainer? container, Func<TService> createDefaultService)
    {
        var service = container != null ? container.TryGetService<TService>() : default;
        return service ?? createDefaultService.Invoke();
    }
}
