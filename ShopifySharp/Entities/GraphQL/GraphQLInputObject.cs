namespace ShopifySharp.GraphQL;

public interface IGraphQLInputObject;

public abstract record GraphQLInputObject<TSelf> : IGraphQLInputObject
    where TSelf : IGraphQLInputObject;
