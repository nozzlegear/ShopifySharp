#nullable enable

namespace ShopifySharp.GraphQL;

public interface IGraphQLObject
{
}

public abstract record GraphQLObject<TSelf> : IGraphQLObject where TSelf : GraphQLObject<TSelf>
{
    public static TSelf? FromJson(string json) => Serializer.Deserialize<TSelf>(json);
}
