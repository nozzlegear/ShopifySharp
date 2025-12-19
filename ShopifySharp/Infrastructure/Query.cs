/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShopifySharp.Infrastructure;

public interface IQuery
{
    /// <summary>Builds the query.</summary>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    /// <exception cref="ArgumentException">Must have a 'Name' specified in the Query</exception>
    /// <exception cref="ArgumentException">Must have a one or more 'Select' fields in the Query</exception>
    string Build();
}

public interface ISelectQuery
{
    void Alias(string alias);

    List<object?> SelectList { get; }

    /// <summary>Gets the query name.</summary>
    string Name { get; }

    /// <summary>Gets the alias name.</summary>
    string? AliasName { get; }
}

public interface IFieldsQuery<TSource> : IQuery, ISelectQuery
{
    void AddField(string field);
    void AddField<TSubSource>(IQuery build)
        where TSubSource : class?;
}

public interface IUnionsQuery : IQuery, ISelectQuery
{
    void AddUnionCase<TUnionType>(string field, IQuery union)
        where TUnionType : class?;
}

public interface IArgumentsQuery : IQuery
{
    // Dictionary<string, object?> Arguments { get; }
    void AddArgument(string key, object? value);
    void AddArguments(Dictionary<string, object?> arguments);
    void AddArguments<TArguments>(TArguments arguments) where TArguments : class;
}

public abstract class SelectQuery : ISelectQuery
{
    protected readonly QueryOptions Options;

    public List<object?> SelectList { get; } = [];
    public string Name { get; }
    public string? AliasName { get; protected set; }

    public SelectQuery(string name, QueryOptions? options = null)
    {
        Name = name;
        Options = options ?? new QueryOptions();
    }

    public void Alias(string alias)
    {
        RequiredArgument.NotNullOrEmpty(alias, nameof(alias));
        AliasName = alias;
    }
}

public class FieldsQuery<TSource>(string name, QueryOptions? options = null)
    : SelectQuery(name, options), IFieldsQuery<TSource>
{
    public string Build()
    {
        throw new NotImplementedException();
    }

    public void AddField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        SelectList.Add(field);
    }

    public void AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?
    {
        RequiredArgument.NotNull(build, nameof(build));
        SelectList.Add(build);
    }
}

public class ArgumentsQuery(QueryOptions options): IArgumentsQuery
{
    private readonly Dictionary<string, object?> _arguments = new();

    public void AddArgument(string key, object? value)
    {
        RequiredArgument.NotNullOrEmpty(key, nameof(key));
        _arguments.Add(key, value);
    }

    public void AddArguments(Dictionary<string, object?> arguments)
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        foreach (var argument in arguments)
            _arguments.Add(argument.Key, argument.Value);
    }

    public void AddArguments<TArguments>(TArguments arguments) where TArguments : class
    {
        RequiredArgument.NotNull(arguments, nameof(arguments));

        IEnumerable<PropertyInfo> properties = arguments
            .GetType()
            .GetProperties()
            .Where(property => property.GetValue(arguments) != null)
            .OrderBy(property => property.Name);
        foreach (var property in properties)
        {
            _arguments.Add(
                GetPropertyName(property),
                property.GetValue(arguments));
        }
    }

    private string GetPropertyName(PropertyInfo property)
    {
        // var thing = new Query<ShopifyProtectOrderSummary>("thing");
        // // TODO: how can we get intellisense on the string fields here? enums are obvious answer, and so are adding an
        // //       individual method for each known field. but stringly typed definitions would be idea
        // thing.AddField("boop");
        //
        return options.Formatter is not null
            ? options.Formatter.Invoke(property)
            : property.Name;
    }

    public string Build()
    {
        throw new NotImplementedException();
    }
}

public class UnionsQuery<TSource>(string name, QueryOptions? options = null)
    : SelectQuery(name, options), IUnionsQuery
{
    public string Build()
    {
        throw new NotImplementedException();
    }

    public void AddUnionCase<TUnionType>(string field, IQuery<TUnionType> union)
        where TUnionType : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(union, nameof(union));

        var fieldQuery = new Query<object>(field, Options);
        fieldQuery.SelectList.Add(union);
        // Ensure we also select the __typename, which is required for deserializing union cases
        fieldQuery.SelectList.Add("__typename");

        SelectList.Add(fieldQuery);
    }
}

public class Query<TSource> : IQuery
{
    protected readonly QueryOptions Options;

    /// <summary>Gets the query string builder.</summary>
    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public string Name { get; }
    public string? AliasName { get; private set; }
    public List<object?> SelectList { get; private set; } = [];

    public Query(string name, QueryOptions? options = null)
    {
        RequiredArgument.NotNullOrEmpty(name, nameof(name));
        Name = name;
        Options = options ?? new QueryOptions();

        Arguments = new ArgumentsQuery(Options);
        Fields = new FieldsQuery<TSource>(Name, Options);
        Unions = new UnionsQuery<TSource>(Name, Options);
    }

    public ArgumentsQuery Arguments { get; private init; }

    public FieldsQuery<TSource> Fields { get; private init; }

    public UnionsQuery<TSource> Unions { get; private init; }

    /// <summary>Builds the query.</summary>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    /// <exception cref="ArgumentException">Must have a 'Name' specified in the Query</exception>
    /// <exception cref="ArgumentException">Must have a one or more 'Select' fields in the Query</exception>
    public string Build()
    {
        QueryStringBuilder.Clear();

        return QueryStringBuilder.Build(this);
    }
}
