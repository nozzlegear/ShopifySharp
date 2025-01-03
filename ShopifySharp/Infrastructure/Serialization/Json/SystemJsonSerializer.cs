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
    private static SystemJsonElement Guard(IJsonElement element) =>
        element as SystemJsonElement ?? throw new ArgumentException($"Expected a {nameof(SystemJsonElement)} but got {element.GetType().FullName}.", nameof(element));

    private static MemoryStream ToStream(IJsonElement value)
    {
        var element = Guard(value).GetRawObject();
        var memoryStream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(memoryStream))
        {
            element.WriteTo(writer);
        }
        memoryStream.Position = 0;
        return memoryStream;
    }

    public IJsonElement Parse(string json) =>
        new SystemJsonElement(JsonDocument.Parse(json));

    public string Serialize<T>(T item) =>
        JsonSerializer.Serialize(item, options);

    public async ValueTask SerializeAsync<T>(Stream target, T item, CancellationToken cancellationToken = default)
    {
        await JsonSerializer.SerializeAsync(target, item, options, cancellationToken);
        // Reset the stream position to 0 so it can be read
        if (target.CanSeek)
            target.Position = 0;
    }

    public object? Deserialize(IJsonElement jsonElement, Type type) => Guard(jsonElement)
        .GetRawObject()
        .Deserialize(type, options);

    public T? Deserialize<T>(IJsonElement jsonElement) => Guard(jsonElement)
        .GetRawObject()
        .Deserialize<T>(options);

    public ValueTask<object?> DeserializeAsync(IJsonElement jsonElement, Type type, CancellationToken cancellationToken = default)
    {
        using var stream = ToStream(jsonElement);
        return JsonSerializer.DeserializeAsync(stream, type, options, cancellationToken);
    }

    public ValueTask<T?> DeserializeAsync<T>(IJsonElement jsonElement, CancellationToken cancellationToken = default)
    {
        using var stream = ToStream(jsonElement);
        return JsonSerializer.DeserializeAsync<T>(stream, options, cancellationToken);
    }
}
