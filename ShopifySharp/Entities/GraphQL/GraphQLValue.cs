namespace ShopifySharp.GraphQL;

using System.Collections.Generic;

/// <summary>
/// Wraps a "primitive" value (i.e. string, int, bool) returned from a GraphQL query or mutation.
/// This allows primitive return types to implement IGraphQLObject while maintaining type safety.
/// </summary>
/// <typeparam name="T">The underlying primitive type (string, int, bool, etc.)</typeparam>
public record GraphQLValue<T> : IGraphQLObject
{
    /// <summary>
    /// The underlying primitive value.
    /// </summary>
    public T Value { get; init; }

    public GraphQLValue(T value)
    {
        Value = value;
    }

    /// <summary>
    /// Implicit conversion to the underlying type.
    /// </summary>
    public static implicit operator T(GraphQLValue<T> wrapper) => wrapper.Value;

    /// <summary>
    /// Implicit conversion from the underlying type.
    /// </summary>
    public static implicit operator GraphQLValue<T>(T value) => new(value);
}
