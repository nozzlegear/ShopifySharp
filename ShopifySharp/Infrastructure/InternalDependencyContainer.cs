using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Infrastructure;

internal class InternalDependencyContainer(params object[] services) : IDependencyContainer
{
    private readonly List<object> _services = services.ToList();

    public TService TryGetService<TService>()
    {
        throw new NotImplementedException();
    }

    public object TryGetService(Type type)
    {
        throw new NotImplementedException();
    }
}
