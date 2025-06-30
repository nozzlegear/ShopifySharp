#nullable enable
namespace ShopifySharp.GraphQL;

public static class GraphQLObjectExtensions
{
    public static string ToJson(this IGraphQLObject o) => Serializer.Serialize(o);
}