namespace ShopifySharp.Infrastructure.Serialization.Json;

public enum JsonNodeValueKind
{
    /// <summary>There is no value (as distinct from <see cref="F:ShopifySharp.Infrastructure.Serialization.Json.JsonNodeValueKind.Null" />).</summary>
    Undefined,
    /// <summary>A JSON object.</summary>
    Object,
    /// <summary>A JSON array.</summary>
    Array,
    /// <summary>A JSON string.</summary>
    String,
    /// <summary>A JSON number.</summary>
    Number,
    /// <summary>The JSON value true.</summary>
    True,
    /// <summary>The JSON value false.</summary>
    False,
    /// <summary>The JSON value null.</summary>
    Null,
}