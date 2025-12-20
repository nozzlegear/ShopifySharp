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
    public OrderQueryArgumentsBuilder Id(string id)
    {
        return this;
    }
}

public sealed class OrderQueryFieldsBuilder(IQuery<ShopifySharp.GraphQL.Order> query)
{
    public OrderQueryFieldsBuilder Name() => this;

    public OrderQueryFieldsBuilder DateCreated() => this;

    public OrderQueryFieldsBuilder DateUpdated() => this;

    public OrderQueryFieldsBuilder Id() => this;
}

public sealed class OrderQueryUnionsBuilder(IQuery<ShopifySharp.GraphQL.Order> query)
{
    public OrderQueryUnionsBuilder PurchasingEntityCustomer(Action<PurchasingEntity> build) => this;
    public OrderQueryUnionsBuilder PurchasingEntityCompany(Action<PurchasingEntity> build) => this;
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

