#nullable enable
using System;

namespace ShopifySharp.Infrastructure;

public interface IDependencyContainer
{
    TService? TryGetService<TService>();
    object? TryGetService(Type type);
}
