namespace ShopifySharp.Extensions;

using System.IO;
using System.Text.Json;

internal static class JsonElementExtensions
{
    public static Stream ToStream(this JsonElement jsonElement)
    {
        var memoryStream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(memoryStream))
        {
            jsonElement.WriteTo(writer);
        }
        memoryStream.Position = 0;
        return memoryStream;
    }
}
