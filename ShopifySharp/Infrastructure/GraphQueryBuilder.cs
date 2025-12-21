/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>
    where T: IGraphQLObject
{
    protected string Name { get; init; }
    protected QueryOptions QueryOptions { get; init; }
    public IQuery<T> Query { get; init; }

    protected GraphQueryBuilder(string name, QueryOptions? queryOptions = null)
    {
        Name = name;
        QueryOptions = queryOptions ?? new QueryOptions();
        Query = new Query<T>(name, QueryOptions);
    }

    public string Build() => Query.Build();
}

public sealed class OrderQueryArgumentsBuilder(IQuery<ShopifySharp.GraphQL.Order> query)
{
    public OrderQueryArgumentsBuilder Id(string id) =>
        throw new NotImplementedException();
}

public sealed class OrderQueryFieldsBuilder(IQuery<ShopifySharp.GraphQL.Order> query)
{
    public OrderQueryFieldsBuilder Name() =>
        throw new NotImplementedException();

    public OrderQueryFieldsBuilder DateCreated() =>
        throw new NotImplementedException();

    public OrderQueryFieldsBuilder DateUpdated() =>
        throw new NotImplementedException();

    public OrderQueryFieldsBuilder Id() =>
        throw new NotImplementedException();
}

public sealed class PurchasingEntityUnionsBuilder(IQuery<ShopifySharp.GraphQL.PurchasingEntity> query)
{
    public PurchasingEntityUnionsBuilder Customer(Action<ShopifySharp.GraphQL.Customer> builder) =>
        throw new NotImplementedException();
    public PurchasingEntityUnionsBuilder Company(Action<ShopifySharp.GraphQL.Company> builder) =>
        throw new NotImplementedException();
}

public sealed class OrderQueryUnionsBuilder(IQuery<ShopifySharp.GraphQL.Order> query)
{
    public PurchasingEntityUnionsBuilder PurchasingEntity { get; } = new(query);
}

public sealed class OrderQueryBuilder : GraphQueryBuilder<ShopifySharp.GraphQL.Order>
{
    public OrderQueryBuilder(QueryOptions? queryOptions = null) : base("order", queryOptions)
    {
        Arguments = new OrderQueryArgumentsBuilder(Query);
        Fields = new OrderQueryFieldsBuilder(Query);
        Unions = new OrderQueryUnionsBuilder(Query);
    }

    public OrderQueryArgumentsBuilder Arguments { get; }
    public OrderQueryFieldsBuilder Fields { get; }
    public OrderQueryUnionsBuilder Unions { get; }
}

