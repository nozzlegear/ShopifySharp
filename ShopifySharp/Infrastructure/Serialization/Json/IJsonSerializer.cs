#nullable enable
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure.Serialization.Json;

// TODO: make this public
internal interface IJsonSerializer
{
    IJsonNode Parse(string value);

    string Serialize<T>(T item);

    ValueTask SerializeAsync<T>(Stream target, T item, CancellationToken cancellationToken = default);

    object? Deserialize(IJsonNode jsonNode, Type type);

    T? Deserialize<T>(IJsonNode jsonNode);

    ValueTask<object?> DeserializeAsync(IJsonNode jsonNode, Type type, CancellationToken cancellationToken = default);

    ValueTask<T?> DeserializeAsync<T>(IJsonNode jsonNode, CancellationToken cancellationToken = default);
}
