#nullable enable
using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp.Infrastructure.Serialization.Json;

// TODO: make this public
internal class SystemJsonSerializer(JsonSerializerOptions options) : IJsonSerializer
{
    private static SystemJsonNode Guard(IJsonNode node) =>
        node as SystemJsonNode ?? throw new ArgumentException($"Expected a {nameof(SystemJsonNode)} but got {node.GetType().FullName}.", nameof(node));

    private static Stream ToStream(IJsonNode node)
    {
        var element = Guard(node).GetRawObject();
        var memoryStream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(memoryStream))
        {
            element.WriteTo(writer);
        }
        memoryStream.Position = 0;
        return memoryStream;
    }

    public IJsonNode Parse(string json) =>
        new SystemJsonNode(JsonDocument.Parse(json));

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
