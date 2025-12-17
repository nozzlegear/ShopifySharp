/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>
    where T: IGraphQLObject
{
    protected QueryOptions QueryOptions { get; init; } = new();

    protected IQuery<T> Query { get; private set; }

    protected readonly string Name;

    protected GraphQueryBuilder(string name)
    {
        Name = name;
        Query = new Query<T>(name, QueryOptions);
    }

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
        RequiredArgument.NotNull(customize, nameof(customize));

        var query = new Query<TField>(name, QueryOptions);
        var subQuery = customize.Invoke(query);

        Query = Query.AddField(subQuery);
    }

    public void AddField<TField, TGraphQueryBuilder>(string name, Func<TGraphQueryBuilder, TGraphQueryBuilder> build)
        where TField : class, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TField>, new()
    {
        var builder = new TGraphQueryBuilder()
        {
            Query = new Query<TField>(name, QueryOptions),
            QueryOptions = QueryOptions
        };
        builder = build.Invoke(builder);

        Query = Query.AddField(builder.Query);
    }

    public GraphQueryBuilder<T> AddUnionCase<TUnionCase, TGraphQueryBuilder>(string fieldName, string unionCaseTypeName, Func<TGraphQueryBuilder, TGraphQueryBuilder> build)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TUnionCase>, new()
    {
        var builder = new TGraphQueryBuilder
        {
            Query = new Query<TUnionCase>($"... on {unionCaseTypeName}"),
            QueryOptions = QueryOptions
        };
        builder = build.Invoke(builder);

        Query = Query.AddUnionCase(fieldName, builder.Query);

        return this;
    }
}
