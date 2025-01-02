using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonObjectEnumerator(JsonElement.ObjectEnumerator objectEnumerator) : IJsonObjectEnumerator
{
    private bool Disposed { get; set;  } = false;

    private JsonElement.ObjectEnumerator _objectEnumerator = objectEnumerator;

    public IEnumerator<IJsonElement> GetEnumerator()
    {
        foreach (var item in _objectEnumerator)
        {
            yield return new SystemJsonElement(item.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Dispose()
    {
        if (Disposed) return;
        _objectEnumerator.Dispose();
        Disposed = true;
    }
}
