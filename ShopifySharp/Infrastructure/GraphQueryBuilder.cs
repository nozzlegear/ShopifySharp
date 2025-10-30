#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>(string name)
    where T: IGraphQLObject
{
    protected IQuery<T> Query { get; private set; } = new Query<T>(name);

    public GraphQueryBuilder<T> Alias(string alias)
    {
        Query = Query.Alias(alias);
        return this;
    }

    public GraphQueryBuilder<T> AddArgument(string key, object? value)
    {
        Query = Query.AddArgument(key, value);
        return this;
    }

    public GraphQueryBuilder<T> AddArguments(Dictionary<string, object?> arguments)
    {
        Query = Query.AddArguments(arguments);
        return this;
    }

    public GraphQueryBuilder<T> AddArguments<TArguments>(TArguments arguments) where TArguments : class
    {
        Query = Query.AddArguments(arguments);
        return this;
    }

    public GraphQueryBuilder<T> AddField(string name)
    {
        Query = Query.AddField(name);
        return this;
    }

    public GraphQueryBuilder<T> AddField<TField>(string name, System.Func<IQuery<TField>, IQuery<TField>> customize)
        where TField: class, IGraphQLObject
    {
        Query = Query.AddField(name, customize);
        return this;
    }

    public GraphQueryBuilder<T> AddUnion<TUnionCase, TGraphQueryBuilder>(string name, Func<GraphQueryBuilder<TUnionCase>, GraphQueryBuilder<TUnionCase>> build)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TUnionCase>, new()
    {
        var thing = new TGraphQueryBuilder();
        var union = build.Invoke(thing);

        Query = Query.AddUnion(union.Query);
    }
}
