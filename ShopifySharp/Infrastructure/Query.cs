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

public interface IQuery<TSource> : IQuery
{
    Dictionary<string, object?> ArgumentsList { get; }

    List<object?> SelectList { get; }

    string Name { get; }

    /// <summary>Gets the alias name.</summary>
    string? AliasName { get; }

    void Alias(string alias);
}

public interface IFieldsBuilder<TSource>
{
    void AddField(string field);
    void AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?;
}

public interface IUnionsBuilder<TSource>
{
    void AddUnionCase<TUnionType>(string field, IQuery<TUnionType> union)
        where TUnionType : class?;
}

public interface IArgumentsBuilder
{
    void AddArgument(string key, object? value);
    void AddArguments(Dictionary<string, object?> arguments);
    void AddArguments<TArguments>(TArguments arguments) where TArguments : class;
}

public class FieldsBuilder<TSource>(ref List<object?> selectList)
    : IFieldsBuilder<TSource>
{
    private readonly List<object?> _selectList = selectList;

    public void AddField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        _selectList.Add(field);
    }

    public void AddField<TSubSource>(IQuery<TSubSource> build)
        where TSubSource : class?
    {
        RequiredArgument.NotNull(build, nameof(build));
        _selectList.Add(build);
    }
}

public class ArgumentsBuilder(QueryOptions options, ref Dictionary<string, object?> arguments)
    : IArgumentsBuilder
{
    private readonly Dictionary<string, object?> _arguments = arguments;

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
}

public class UnionsBuilder<TSource>(QueryOptions options, ref List<object?> selectList)
    : IUnionsBuilder<TSource>
{
    private readonly List<object?> _selectList = selectList;

    public void AddUnionCase<TUnionType>(string field, IQuery<TUnionType> union)
        where TUnionType : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(union, nameof(union));

        var fieldQuery = new Query<object>(field, options);
        fieldQuery.SelectList.Add(union);
        // Ensure we also select the __typename, which is required for deserializing union cases
        fieldQuery.SelectList.Add("__typename");

        _selectList.Add(fieldQuery);
    }
}

public class Query<TSource> : IQuery<TSource>
{
    protected readonly QueryOptions Options;

    public Dictionary<string, object?> ArgumentsList { get; }

    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public string Name { get; }

    public string? AliasName { get; private set; }

    public List<object?> SelectList { get; }

    public Query(string name, QueryOptions? options = null)
    {
        RequiredArgument.NotNullOrEmpty(name, nameof(name));
        Name = name;
        Options = options ?? new QueryOptions();

        var argumentsList = new Dictionary<string, object?>();
        ArgumentsList = argumentsList;

        var selectList = new List<object?>();
        SelectList = selectList;

        Arguments = new ArgumentsBuilder(Options, ref argumentsList);
        Fields = new FieldsBuilder<TSource>(ref selectList);
        Unions = new UnionsBuilder<TSource>(Options, ref selectList);
    }

    public ArgumentsBuilder Arguments { get; private init; }

    public FieldsBuilder<TSource> Fields { get; private init; }

    public UnionsBuilder<TSource> Unions { get; private init; }

    public void Alias(string alias)
    {
        AliasName = alias;
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
}
