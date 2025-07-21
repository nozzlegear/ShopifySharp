#nullable enable

namespace ShopifySharp.GraphQL;

public interface IGraphQLObject;

public abstract record GraphQLObject<TNode> : IGraphQLObject where TNode : IGraphQLObject
{
    #if NET6_0_OR_GREATER
    public static IGraphQLObject? FromJson(string json) => Serializer.Deserialize<IGraphQLObject>(json);
    #endif
}
