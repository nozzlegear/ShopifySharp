#nullable enable
using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonSerializer(JsonSerializerOptions options) : IJsonSerializer
{
    public string Serialize<T>(T item) =>
        JsonSerializer.Serialize(item, options);

    public ValueTask SerializeAsync<T>(Stream target, T item, CancellationToken cancellationToken = default) =>
        new(JsonSerializer.SerializeAsync(target, item, options, cancellationToken));

    public object? Deserialize(IJsonNode jsonNode, Type type) => Guard(jsonNode)
        .GetRawObject()
        .Deserialize(type, options);

    public T? Deserialize<T>(IJsonNode jsonNode) => Guard(jsonNode)
        .GetRawObject()
        .Deserialize<T>(options);

    public ValueTask<object?> DeserializeAsync(IJsonNode jsonNode, Type type, CancellationToken cancellationToken = default)
    {
        using var stream = ToStream(jsonNode);
        return JsonSerializer.DeserializeAsync(stream, type, options, cancellationToken);
    }

    public ValueTask<T?> DeserializeAsync<T>(IJsonNode jsonNode, CancellationToken cancellationToken = default)
    {
        using var stream = ToStream(jsonNode);
        return JsonSerializer.DeserializeAsync<T>(stream, options, cancellationToken);
    }
}
