using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShopifySharp;

internal static class DictionaryExtensions
{
    public static void AddRange(this IDictionary<string, object> dictionary, IEnumerable<KeyValuePair<string, object>> kvps)
    {
        foreach (var kvp in kvps)
        {
            dictionary.Add(kvp.Key, kvp.Value);
        }
    }

    public static IReadOnlyDictionary<string, T> ToReadOnlyDictionary<T>(this IDictionary<string, T> dictionary)
    {
        return new ReadOnlyDictionary<string, T>(dictionary);
    }
}
