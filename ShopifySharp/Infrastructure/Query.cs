/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;
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
    // TODO: the IQuery here just gets merged with the IFieldsBuilder's own IQuery SelectList, which should put the queries
    //       on the same level.
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
    List<object?> SelectList { get; }
    Dictionary<string, object?> Arguments { get; }
    IQuery<TSource> Alias(string alias);
}

public class Query<TSource> : IQuery<TSource>
{
    /// <summary>Gets the query string builder.</summary>
    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public QueryOptions Options { get; }
    public string Name { get; }
    public string? AliasName { get; private set; }
    public List<object?> SelectList { get; } = [];
    public Dictionary<string, object?> Arguments { get; } = [];

    public Query(string name, QueryOptions? options = null)
    {
        RequiredArgument.NotNullOrEmpty(name, nameof(name));
        Name = name;
        Options = options ?? new QueryOptions();
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
        AliasName = alias;
        return this;
    }

    public IQuery<TSource> AddField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        SelectList.Add(field);
        return this;
    }

    public IQuery<TSource> AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?
    {
        RequiredArgument.NotNull(build, nameof(build));
        SelectList.Add(build);
        return this;
    }

    public IQuery<TSource> AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class?
    {
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        // Ensure we also select the __typename, which is required for deserializing union cases
        unionCaseQuery.SelectList.Add("__typename");
        SelectList.Add(unionCaseQuery);

        return this;
    }

    public IQuery<TSource> AddUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(unionCaseQuery, nameof(unionCaseQuery));

        var fieldQuery = new Query<object>(field, Options);
        fieldQuery.SelectList.AddRange([
            // Ensure we also select the __typename, which is required for deserializing union cases
            "__typename",
            unionCaseQuery
        ]);
        SelectList.Add(fieldQuery);

        return this;
    }

    public IQuery<TSource> AddArgument(string key, object? value)
    {
        RequiredArgument.NotNullOrEmpty(key, nameof(key));
        Arguments.Add(key, value);
        return this;
    }

    public IQuery<TSource> AddArguments(Dictionary<string, object?> arguments)
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        foreach (var argument in arguments)
            Arguments.Add(argument.Key, argument.Value);

        return this;
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

public abstract class FieldsBuilderBase<TSource>(IQuery<TSource> query): IFieldsBuilder<IQuery<TSource>>
{
    protected readonly IQuery<TSource> Query = query;

    public IQuery<TSource> AddField(string field) =>
        Query.AddField(field);

    public IQuery<TSource> AddField<TSubSource>(IQuery<TSubSource> build) where TSubSource : class? =>
        Query.AddField(build);

    public IQuery<TSource> AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery) where TUnionCase : class? =>
        Query.AddUnionCase(unionCaseQuery);
}

public abstract class ArgumentsBuilderBase<TSource>(IQuery<TSource> query): IArgumentsBuilder<IQuery<TSource>>
{
    protected readonly IQuery<TSource> Query = query;

    public IQuery<TSource> AddArgument(string key, object? value) =>
        Query.AddArgument(key, value);

    public IQuery<TSource> AddArguments(Dictionary<string, object?> arguments) =>
        Query.AddArguments(arguments);
}

public abstract class UnionCaseBuilderBase<TSource>(IQuery<TSource> query): IUnionCaseBuilder<IQuery<TSource>>
{
    protected readonly IQuery<TSource> Query = query;

    public IQuery<TSource> AddUnionCase<TUnionType>(string field, IQuery<TUnionType> unionCaseQuery)
        where TUnionType : class? =>
        Query.AddUnionCase(field, unionCaseQuery);
}
