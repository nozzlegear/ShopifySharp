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
    TQuery WithArgument(string key, object? value);
    TQuery WithArguments(IDictionary<string, object?> arguments);
}

public interface IUnionCaseBuilder<out TQuery>
{
    TQuery WithUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery)
        where TUnionCase : class?;
    TQuery WithUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?;
}

public interface IFieldsBuilder<out TQuery> : IUnionCaseBuilder<TQuery>
{
    TQuery WithField(string field);
    TQuery WithField<TSubSource>(IQuery<TSubSource> subQuery)
        where TSubSource : class?;
}

public interface IQuery<TSource> : IQuery, IArgumentsBuilder<IQuery<TSource>>, IFieldsBuilder<IQuery<TSource>>
{
    List<object?> SelectList { get; }
    List<string, object?> Arguments { get; }
    IQuery<TSource> WithAlias(string alias);
}

public class Query<TSource> : IQuery<TSource>
{
    /// <summary>Gets the query string builder.</summary>
    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public QueryOptions Options { get; }
    public string Name { get; }
    public string? AliasName { get; private init; }
    public ImmutableList<object?> SelectList { get; }
    public ImmutableDictionary<string, object?> Arguments { get; }

    public Query(string name, QueryOptions? options = null)
    {
        RequiredArgument.NotNullOrEmpty(name, nameof(name));
        Name = name;
        Options = options ?? new QueryOptions();
        SelectList = ImmutableList<object?>.Empty;
        Arguments = ImmutableDictionary<string, object?>.Empty;
    }

    // Private copy constructor for creating new instances with modified state
    private Query(string name, QueryOptions options,
                  ImmutableList<object?> selectList,
                  ImmutableDictionary<string, object?> arguments,
                  string? aliasName)
    {
        Name = name;
        Options = options;
        SelectList = selectList;
        Arguments = arguments;
        AliasName = aliasName;
    }

    /// <summary>Builds the query.</summary>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    /// <exception cref="ArgumentException">Must have a 'Name' specified in the Query</exception>
    /// <exception cref="ArgumentException">Must have a one or more 'Select' fields in the Query</exception>
    public string Build()
    {
        this.QueryStringBuilder.Clear();

        return this.QueryStringBuilder.Build(this);
    }


    public IQuery<TSource> WithAlias(string alias)
    {
        RequiredArgument.NotNullOrEmpty(alias, nameof(alias));
        return new Query<TSource>(Name, Options, SelectList, Arguments, alias);
    }

    public IQuery<TSource> WithField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        return new Query<TSource>(Name, Options, SelectList.Add(field), Arguments, AliasName);
    }

    public IQuery<TSource> WithField<TSubSource>(IQuery<TSubSource> subQuery)
        where TSubSource : class?
    {
        RequiredArgument.NotNull(subQuery, nameof(subQuery));
        return new Query<TSource>(Name, Options, SelectList.Add(subQuery), Arguments, AliasName);
    }

    public IQuery<TSource> WithUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        // Ensure we also select the __typename, which is required for deserializing union cases
        var updatedUnionQuery = unionCaseQuery.WithField("__typename");

        return new Query<TSource>(Name, Options, SelectList.Add(updatedUnionQuery), Arguments, AliasName);
    }

    public IQuery<TSource> WithUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        var fieldQuery = new Query<object>(field, Options);
        // Ensure we also select the __typename, which is required for deserializing union cases
        var updatedFieldQuery = fieldQuery
            .WithField("__typename")
            .WithField(unionCaseQuery);

        return new Query<TSource>(Name, Options, SelectList.Add(updatedFieldQuery), Arguments, AliasName);
    }

    public IQuery<TSource> WithArgument(string key, object? value)
    {
        RequiredArgument.NotNullOrEmpty(key, nameof(key));
        return new Query<TSource>(Name, Options, SelectList, Arguments.Add(key, value), AliasName);
    }

    public IQuery<TSource> WithArguments(IDictionary<string, object?> arguments)
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        var updatedArguments = Arguments.AddRange(arguments);

        return new Query<TSource>(Name, Options, SelectList, updatedArguments, AliasName);
    }
}

public abstract class ArgumentsBuilderBase<TSource>(IQuery<TSource> query): IArgumentsBuilder<IQuery<TSource>>
{
    protected IQuery<TSource> Query = query;

    public IQuery<TSource> WithArgument(string key, object? value)
    {
        Query = Query.WithArgument(key, value);
        return Query;
    }

    public IQuery<TSource> WithArguments(IDictionary<string, object?> arguments)
    {
        Query = Query.WithArguments(arguments);
        return Query;
    }
}

public abstract class UnionCaseBuilderBase<TSource>(IQuery<TSource> query): IUnionCaseBuilder<IQuery<TSource>>
{
    protected IQuery<TSource> Query = query;

    public IQuery<TSource> WithUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        Query = Query.WithUnionCase(unionCaseQuery);
        return Query;
    }

    public IQuery<TSource> WithUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?
    {
        Query = Query.WithUnionCase(field, unionCaseQuery);
        return Query;
    }
}
