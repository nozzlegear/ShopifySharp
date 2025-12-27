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

public interface IQuery<TSource> : IQuery
{
    List<object?> SelectList { get; }
    Dictionary<string, object?> Arguments { get; }
    IQuery<TSource> Alias(string alias);
    IQuery<TSource> AddField(string field);
    IQuery<TSource> AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?;
    IQuery<TSource> AddUnionCase<TUnionType>(string field, IQuery<TUnionType> union)
        where TUnionType : class?;
    IQuery<TSource> AddArgument(string key, object? value);
    IQuery<TSource> AddArguments(Dictionary<string, object?> arguments);
    IQuery<TSource> AddArguments<TArguments>(TArguments arguments) where TArguments : class;
}

public class Query<TSource> : IQuery<TSource>
{
    protected readonly QueryOptions Options;

    /// <summary>Gets the query string builder.</summary>
    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public string Name { get; }
    public string? AliasName { get; private set; }
    public List<object?> SelectList { get; private set; } = [];
    public Dictionary<string, object?> Arguments { get; private set; } = [];

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

    public IQuery<TSource> AddUnionCase<TUnionType>(string field, IQuery<TUnionType> union)
        where TUnionType : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(union, nameof(union));

        var fieldQuery = new Query<object>(field, Options);
        fieldQuery.SelectList.Add(union);
        // Ensure we also select the __typename, which is required for deserializing union cases
        fieldQuery.SelectList.Add("__typename");

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

    public void AddField<TField>(string name, Func<IQuery<TField>, IQuery<TField>> customize)
        where TField: class, IGraphQLObject
    {
        RequiredArgument.NotNull(customize, nameof(customize));

        var query = new Query<TField>(name, Options);
        var subQuery = customize.Invoke(query);

        AddField(subQuery);
    }

    public void AddField<TField, TQueryBuilder>(string name, Func<TQueryBuilder, TQueryBuilder> build)
        where TField : class, IGraphQLObject
        where TQueryBuilder : GraphQueryBuilder<TField>
    {
        var query = new Query<TField>(name, Options);
        throw new NotImplementedException("todo: replace this with an implementation of this method on the actual XYZQueryBuilder class itself");
        // var builder = new GraphQueryBuilder<TField>(name);
        // builder = build.Invoke(builder);
        //
        // Query = Query.AddField(builder.Query);
    }

    public void AddUnionCase<TUnionCase, TGraphQueryBuilder>(string fieldName, string unionCaseTypeName, Func<TGraphQueryBuilder, TGraphQueryBuilder> build)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
        where TGraphQueryBuilder : GraphQueryBuilder<TUnionCase>, new()
    {
        throw new NotImplementedException("todo: replace this with an implementation of this method on the actual XYZQueryBuilder class itself");
        // var builder = new TGraphQueryBuilder
        // {
        //     Query = new Query<TUnionCase>($"... on {unionCaseTypeName}"),
        //     QueryOptions = QueryOptions
        // };
        // builder = build.Invoke(builder);
        //
        // Query.AddUnionCase(fieldName, builder.Query);
    }

    public IQuery<TSource> AddArguments<TArguments>(TArguments arguments) where TArguments : class
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        IEnumerable<PropertyInfo> properties = arguments
            .GetType()
            .GetProperties()
            .Where(property => property.GetValue(arguments) != null)
            .OrderBy(property => property.Name);
        foreach (var property in properties)
        {
            Arguments.Add(
                GetPropertyName(property),
                property.GetValue(arguments));
        }

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
