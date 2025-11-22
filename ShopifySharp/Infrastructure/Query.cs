#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    IQuery<TSource> AddField<TProperty>(Expression<Func<TSource, TProperty>> selector);
    IQuery<TSource> AddField(string field);
    IQuery<TSource> AddField<TSubSource>(string field, IQuery<TSubSource> build)
        where TSubSource : class?;
    IQuery<TSource> AddField<TSubSource>(
        string field,
        Func<IQuery<TSubSource>, IQuery<TSubSource>> build)
        where TSubSource : class?;
    IQuery<TSource> AddUnion<TUnionType>(IQuery<TUnionType> union)
        where TUnionType : class?;
    IQuery<TSource> AddUnion<TUnionType>(
        string typeName,
        Func<IQuery<TUnionType>, IQuery<TUnionType>> build)
        where TUnionType : class?, TSource;
    IQuery<TSource> AddUnion<TUnionType>(
        Func<IQuery<TUnionType>, IQuery<TUnionType>> build)
        where TUnionType : class?, TSource;
    IQuery<TSource> AddArgument(string key, object? value);
    IQuery<TSource> AddArguments(Dictionary<string, object?> arguments);
    IQuery<TSource> AddArguments<TArguments>(TArguments arguments) where TArguments : class;
}

public class Query<TSource> : IQuery<TSource>
{
    protected readonly QueryOptions Options;

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

    public string Build()
    {
        throw new NotImplementedException();
    }

    public IQuery<TSource> Alias(string alias)
    {
        RequiredArgument.NotNullOrEmpty(alias, nameof(alias));
        AliasName = alias;
        return this;
    }

    public IQuery<TSource> AddField<TProperty>(Expression<Func<TSource, TProperty>> selector)
    {
        RequiredArgument.NotNull(selector, nameof(selector));
        var property = GetPropertyInfo(selector);
        var name = GetPropertyName(property);

        SelectList.Add(name);

        return this;
    }

    public IQuery<TSource> AddField(string field)
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        SelectList.Add(field);
        return this;
    }

    public IQuery<TSource> AddField<TSubSource>(
        Expression<Func<TSource, TSubSource>> selector,
        Func<IQuery<TSubSource>, IQuery<TSubSource>> build
    ) where TSubSource : class?
    {
        RequiredArgument.NotNull(selector, nameof(selector));
        RequiredArgument.NotNull(build, nameof(build));

        var property = GetPropertyInfo(selector);
        var name = GetPropertyName(property);

        return AddField(name, build);
    }

    public IQuery<TSource> AddField<TSubSource>(
        Expression<Func<TSource, IEnumerable<TSubSource>>> selector,
        Func<IQuery<TSubSource>, IQuery<TSubSource>> build
    ) where TSubSource : class?
    {
        RequiredArgument.NotNull(selector, nameof(selector));
        RequiredArgument.NotNull(build, nameof(build));

        var property = GetPropertyInfo(selector);
        var name = GetPropertyName(property);

        return AddField(name, build);
    }

    public IQuery<TSource> AddField<TSubSource>(string field, Func<IQuery<TSubSource>, IQuery<TSubSource>> build)
        where TSubSource : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(build, nameof(build));

        var query = new Query<TSubSource>(field, Options);
        var subQuery = build.Invoke(query);

        SelectList.Add(subQuery);

        return this;
    }

    public IQuery<TSource> AddField<TSubSource>(string field, IQuery<TSubSource> build)
        where TSubSource : class?
    {
        RequiredArgument.NotNullOrEmpty(field, nameof(field));
        RequiredArgument.NotNull(build, nameof(build));

        SelectList.Add(build);

        return this;
    }

    public IQuery<TSource> AddUnion<TUnionType>(IQuery<TUnionType> union)
        where TUnionType : class?
    {
        RequiredArgument.NotNull(union, nameof(union));

        SelectList.Add(union);

        return this;
    }

    public IQuery<TSource> AddUnion<TUnionType>(string typeName, Func<IQuery<TUnionType>, IQuery<TUnionType>> build)
        where TUnionType : class?, TSource
    {
        RequiredArgument.NotNullOrEmpty(typeName, nameof(typeName));
        RequiredArgument.NotNull(build, nameof(build));

        var query = new Query<TUnionType>($"... on {typeName}", Options);
        var union = build.Invoke(query);

        return AddUnion(union);
    }

    public IQuery<TSource> AddUnion<TUnionType>(Func<IQuery<TUnionType>, IQuery<TUnionType>> build)
        where TUnionType : class?, TSource
    {
        RequiredArgument.NotNull(build, nameof(build));
        return AddUnion(typeof(TUnionType).Name, build);
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

    private static PropertyInfo GetPropertyInfo<TProperty>(Expression<Func<TSource, TProperty>> lambda)
    {
        if (lambda.Body is not MemberExpression member)
            throw new ArgumentException($"Expression '{lambda}' body is not member expression.");

        if (member.Member is not PropertyInfo propertyInfo)
            throw new ArgumentException($"Expression '{lambda}' not refers to a property.");

        if (propertyInfo.ReflectedType is null)
            throw new ArgumentException($"Expression '{lambda}' not refers to a property.");

        var type = typeof(TSource);
        if (type != propertyInfo.ReflectedType && !propertyInfo.ReflectedType.IsAssignableFrom(type))
            throw new ArgumentException($"Expression '{lambda}' refers to a property that is not from type {type}.");

        return propertyInfo;
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
