namespace ShopifySharp.GraphQL;

using System.Collections.Generic;

/// <summary>
/// Wraps a collection of "primitive" values (i.e. strings, numbers, bools) returned from a GraphQL query or mutation.
/// This allows collection return types to implement IGraphQLObject while maintaining type safety.
/// </summary>
/// <typeparam name="T">The type of the collection's elements</typeparam>
public record GraphQLCollection<T> : IGraphQLObject
{
    public ICollection<T> Value { get; init; } = new List<T>();
}
