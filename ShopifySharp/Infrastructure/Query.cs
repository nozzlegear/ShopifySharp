/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using ShopifySharp.GraphQL;

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
    TQuery AddArguments(Dictionary<string, object?> arguments);
}

public interface IFieldsBuilder<out TQuery>
{
    TQuery AddField(string field);
    TQuery AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?;
    TQuery AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery)
        where TUnionCase : class?;
}

public interface IUnionCaseBuilder<out TQuery>
{
    TQuery AddUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?;
}

public interface IQuery<TSource> : IQuery, IArgumentsBuilder<IQuery<TSource>>, IFieldsBuilder<IQuery<TSource>>, IUnionCaseBuilder<IQuery<TSource>>
{
    ImmutableList<object?> SelectList { get; }
    ImmutableDictionary<string, object?> Arguments { get; }
    IQuery<TSource> Alias(string alias);
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


    public IQuery<TSource> Alias(string alias)
    {
        RequiredArgument.NotNullOrEmpty(alias, nameof(alias));
        return new Query<TSource>(Name, Options, SelectList, Arguments, alias);
    }

    public IQuery<TSource> AddField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        return new Query<TSource>(Name, Options, SelectList.Add(field), Arguments, AliasName);
    }

    public IQuery<TSource> AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?
    {
        RequiredArgument.NotNull(build, nameof(build));
        return new Query<TSource>(Name, Options, SelectList.Add(build), Arguments, AliasName);
    }

    public IQuery<TSource> AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        // Ensure we also select the __typename, which is required for deserializing union cases
        var updatedUnionQuery = unionCaseQuery.AddField("__typename");

        return new Query<TSource>(Name, Options, SelectList.Add(updatedUnionQuery), Arguments, AliasName);
    }

    public IQuery<TSource> AddUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        var fieldQuery = new Query<object>(field, Options);
        // Ensure we also select the __typename, which is required for deserializing union cases
        var updatedFieldQuery = fieldQuery
            .AddField("__typename")
            .AddField(unionCaseQuery);

        return new Query<TSource>(Name, Options, SelectList.Add(updatedFieldQuery), Arguments, AliasName);
    }

    public IQuery<TSource> AddArgument(string key, object? value)
    {
        RequiredArgument.NotNullOrEmpty(key, nameof(key));
        return new Query<TSource>(Name, Options, SelectList, Arguments.Add(key, value), AliasName);
    }

    public IQuery<TSource> AddArguments(Dictionary<string, object?> arguments)
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        var updatedArguments = Arguments.AddRange(arguments);

        return new Query<TSource>(Name, Options, SelectList, updatedArguments, AliasName);
    }

    private string GetPropertyName(PropertyInfo property)
    {
        // var thing = new Query<ShopifyProtectOrderSummary>("thing");
        // // TODO: how can we get intellisense on the string fields here? enums are obvious answer, and so are adding an
        // //       individual method for each known field. but stringly typed definitions would be idea
        // thing.AddField("boop");
        //
        return Options.Formatter is not null
            ? Options.Formatter.Invoke(property)
            : property.Name;
    }
}

public abstract class ArgumentsBuilderBase<TSource>(IQuery<TSource> query): IArgumentsBuilder<IQuery<TSource>>
{
    protected IQuery<TSource> Query = query;

    // IArgumentsBuilder implementation (internal interface)
    public IQuery<TSource> AddArgument(string key, object? value)
    {
        Query = Query.AddArgument(key, value);
        return Query;
    }

    public IQuery<TSource> AddArguments(Dictionary<string, object?> arguments)
    {
        Query = Query.AddArguments(arguments);
        return Query;
    }

    // Public API with WithArgument naming (generated code will use these)
    public IQuery<TSource> WithArgument(string key, object? value) => AddArgument(key, value);
    public IQuery<TSource> WithArguments(Dictionary<string, object?> arguments) => AddArguments(arguments);
}

public abstract class UnionCaseBuilderBase<TSource>(IQuery<TSource> query): IUnionCaseBuilder<IQuery<TSource>>
{
    protected IQuery<TSource> Query = query;

    public IQuery<TSource> AddUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?
    {
        Query = Query.AddUnionCase(field, unionCaseQuery);
        return Query;
    }
}
