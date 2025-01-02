using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonNodeObjectEnumerator(JsonElement.ObjectEnumerator objectEnumerator) : IJsonNodeObjectEnumerator
{
    private bool Disposed { get; set;  } = false;

    private JsonElement.ObjectEnumerator _objectEnumerator = objectEnumerator;

    public IEnumerator<IJsonNode> GetEnumerator()
    {
        foreach (var item in _objectEnumerator)
        {
            yield return new SystemJsonNode(item.Value);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Dispose()
    {
        if (Disposed) return;
        _objectEnumerator.Dispose();
    }
}
