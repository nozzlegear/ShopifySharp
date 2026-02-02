using System.Text.Json;

namespace ShopifySharp.Infrastructure.Serialization.Json;

internal class SystemJsonWriter(Utf8JsonWriter writer) : IJsonWriter
{
    public Utf8JsonWriter Writer => writer;

    public void WriteNullValue() =>
        writer.WriteNullValue();
}
