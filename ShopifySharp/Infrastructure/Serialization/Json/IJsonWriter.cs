namespace ShopifySharp.Infrastructure.Serialization.Json;

internal interface IJsonWriter
{
    /// <summary>
    /// Writes the JSON literal null.
    /// </summary>
    void WriteNullValue();
}
