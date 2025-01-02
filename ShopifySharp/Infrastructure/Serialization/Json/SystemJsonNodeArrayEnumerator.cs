using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonNodeArrayEnumerator(JsonElement.ArrayEnumerator arrayEnumerator) : IJsonNodeArrayEnumerator
{
    private bool Disposed { get; set;  } = false;

    private JsonElement.ArrayEnumerator _arrayEnumerator = arrayEnumerator;

    public IEnumerator<IJsonNode> GetEnumerator()
    {
        foreach (var item in _arrayEnumerator)
        {
            yield return new SystemJsonNode(item);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Dispose()
    {
        if (Disposed) return;
        _arrayEnumerator.Dispose();
    }
}
