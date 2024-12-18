#nullable enable
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ShopifySharp.Infrastructure;

/// <summary>
/// An internal implementation of <see cref="System.IServiceProvider"/>, which should only be used in cases where the
/// interface is insufficient and an implementation is needed.
/// </summary>
internal class InternalServiceProvider(params object?[] initialServices) : IServiceProvider
{
    private readonly ReadOnlyDictionary<Type, object> _services = new(initialServices.Where(x => x is not null)
        .Cast<object>()
        .ToDictionary(x => x.GetType()));

    public object? GetService(Type serviceType)
    {
        _services.TryGetValue(serviceType, out var service);
        return service;
    }
}
