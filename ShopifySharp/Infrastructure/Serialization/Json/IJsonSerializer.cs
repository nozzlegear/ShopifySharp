#nullable enable
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure.Serialization.Json;

// TODO: make this public
internal interface IJsonSerializer
{
    string Serialize<T>(T item);
    ValueTask SerializeAsync<T>(Stream target, T item, CancellationToken cancellationToken = default);
    T? Deserialize<T>(string value);
    ValueTask<T?> DeserializeAsync<T>(Stream source, CancellationToken cancellationToken = default);
    object? DeserializeObject(string value, Type type);
    ValueTask<object?> DeserializeObjectAsync(Stream source, Type type, CancellationToken cancellationToken = default);
}
