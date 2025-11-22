#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>(string name)
    where T: IGraphQLObject
{
    protected IQuery<T> Query { get; private set; } = new Query<T>(name);

    public void Alias(string alias)
    {
        Query = Query.Alias(alias);
    }

    public void AddArgument(string key, object? value)
    {
        Query = Query.AddArgument(key, value);
    }

    public void AddArguments(Dictionary<string, object?> arguments)
    {
        Query = Query.AddArguments(arguments);
    }

    public void AddArguments<TArguments>(TArguments arguments) where TArguments : class
    {
        Query = Query.AddArguments(arguments);
    }

    public void AddField(string name)
    {
        Query = Query.AddField(name);
    }

    public void AddField<TField>(string name, Func<IQuery<TField>, IQuery<TField>> customize)
        where TField: class, IGraphQLObject
    {
        Query = Query.AddField(name, customize);
    }

    public void AddUnion<TUnionCase, TGraphQueryBuilder>(string name, Func<GraphQueryBuilder<TUnionCase>, GraphQueryBuilder<TUnionCase>> build)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TUnionCase>, new()
    {
        var thing = new TGraphQueryBuilder();
        var union = build.Invoke(thing);

        Query.AddUnion(union.Query);
    }

    public void AddUnion<TUnionCase>(string name, GraphQueryBuilder<TUnionCase> union)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
    {
        Query.AddUnion(union.Query);
    }
}
