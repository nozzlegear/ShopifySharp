/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>(string name)
    where T: IGraphQLObject
{
    protected IQuery<T> Query { get; private set; } = new Query<T>(name);

    public string Build() => Query.Build();

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

    public void AddField<TField, TGraphQueryBuilder>(string name, Func<TGraphQueryBuilder, TGraphQueryBuilder> build)
        where TField : class, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TField>, new()
    {
        var builder = new TGraphQueryBuilder();
        var field = build.Invoke(builder);

        Query = Query.AddField(name, field.Query);
    }

    public GraphQueryBuilder<T> AddUnionCase<TUnionCase, TGraphQueryBuilder>(string name, Func<TGraphQueryBuilder, TGraphQueryBuilder> build)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TUnionCase>, new()
    {
        var builder = new TGraphQueryBuilder();
        var union = build.Invoke(builder);

        Query = Query.AddUnionCase(union.Query);

        return this;
    }

    public GraphQueryBuilder<T> AddUnionCase<TUnionCase>(string name, GraphQueryBuilder<TUnionCase> union)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
    {
        Query = Query.AddUnionCase(union.Query);

        return this;
    }
}
