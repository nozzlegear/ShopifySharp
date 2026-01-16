/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;

namespace ShopifySharp.Infrastructure;

public interface IQuery
{
    QueryOptions Options { get; }

    /// <summary>Gets the query name.</summary>
    string Name { get; }

    /// <summary>Gets the alias name.</summary>
    string? AliasName { get; }

    /// <summary>Builds the query.</summary>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    /// <exception cref="ArgumentException">Must have a 'Name' specified in the Query</exception>
    /// <exception cref="ArgumentException">Must have a one or more 'Select' fields in the Query</exception>
    string Build();
}

public interface IArgumentsBuilder<out TQuery>
{
    TQuery AddArgument(string key, object? value);
    TQuery AddArguments(IDictionary<string, object?> arguments);
}

public interface IUnionCaseBuilder<out TQuery>
{
    TQuery AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery)
        where TUnionCase : class?;
}

public interface IFieldsBuilder<out TQuery> : IUnionCaseBuilder<TQuery>
{
    TQuery AddField(string field);
    TQuery AddField(IQuery subQuery);
    TQuery AddField<TSubSource>(IQuery<TSubSource> subQuery)
        where TSubSource : class?;
}

public interface IQuery<out TSource> : IQuery, IArgumentsBuilder<IQuery<TSource>>, IFieldsBuilder<IQuery<TSource>>
{
    List<object?> SelectList { get; }
    Dictionary<string, object?> Arguments { get; }
    IQuery<TSource> WithAlias(string alias);
}

public class Query<TSource> : IQuery<TSource>
{
    /// <summary>Gets the query string builder.</summary>
    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public QueryOptions Options { get; }
    public string Name { get; }
    public string? AliasName { get; protected set; }
    public List<object?> SelectList { get; }
    public Dictionary<string, object?> Arguments { get; }

    public Query(string name, QueryOptions? options = null)
    {
        RequiredArgument.NotNullOrEmpty(name, nameof(name));
        Name = name;
        Options = options ?? new QueryOptions();
        SelectList = [];
        Arguments = [];
    }

    /// <summary>Builds the query.</summary>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    /// <exception cref="ArgumentException">Must have a 'Name' specified in the Query</exception>
    /// <exception cref="ArgumentException">Must have a one or more 'Select' fields in the Query</exception>
    public string Build()
    {
        QueryStringBuilder.Clear();
        return QueryStringBuilder.Build(this);
    }


    public IQuery<TSource> WithAlias(string alias)
    {
        RequiredArgument.NotNullOrEmpty(alias, nameof(alias));
        AliasName = alias;
        return this;
    }

    public IQuery<TSource> AddField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        SelectList.Add(field);
        return this;
    }

    public IQuery<TSource> AddField(IQuery subQuery)
    {
        RequiredArgument.NotNull(subQuery, nameof(subQuery));
        SelectList.Add(subQuery);
        return this;
    }

    public IQuery<TSource> AddField<TSubSource>(IQuery<TSubSource> subQuery)
        where TSubSource : class?
    {
        RequiredArgument.NotNull(subQuery, nameof(subQuery));
        SelectList.Add(subQuery);
        return this;
    }

    public IQuery<TSource> AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        // Ensure we also select the __typename, which is required for deserializing union cases
        SelectList.Add(unionCaseQuery.AddField("__typename"));

        return this;
    }

    public IQuery<TSource> AddArgument(string key, object? value)
    {
        RequiredArgument.NotNullOrEmpty(key, nameof(key));

        Arguments.Add(key, value);

        return this;
    }

    public IQuery<TSource> AddArguments(IDictionary<string, object?> arguments)
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        Arguments.AddRange(arguments);

        return this;
    }
}

public abstract class ArgumentsBuilderBase<TSource>(IQuery<TSource> query): IArgumentsBuilder<IQuery<TSource>>
{
    protected readonly IQuery<TSource> Query = query;

    public IQuery<TSource> AddArgument(string key, object? value)
    {
        Query.AddArgument(key, value);
        return Query;
    }

    public IQuery<TSource> AddArguments(IDictionary<string, object?> arguments)
    {
        Query.AddArguments(arguments);
        return Query;
    }
}

public abstract class UnionCaseBuilderBase<TSource>(IQuery<TSource> query): IUnionCaseBuilder<IQuery<TSource>>
{
    protected readonly IQuery<TSource> Query = query;

    public IQuery<TSource> AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        Query.AddUnionCase(unionCaseQuery);
        return Query;
    }
}
