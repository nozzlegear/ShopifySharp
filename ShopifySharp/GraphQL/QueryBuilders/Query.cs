/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.GraphQL.QueryBuilders;

[PublicAPI]
public interface IQuery
{
    /// <summary>Gets the query name.</summary>
    string QueryName { get; }

    /// <summary>Gets the alias name.</summary>
    string? AliasName { get; }

    /// <summary>Builds the query.</summary>
    /// <returns>The GraphQL query as string, without outer enclosing block.</returns>
    /// <exception cref="ArgumentException">Must have a 'Name' specified in the Query</exception>
    /// <exception cref="ArgumentException">Must have a one or more 'Select' fields in the Query</exception>
    string Build();
}

[PublicAPI]
public interface IArgumentsBuilder<out TSelf> where TSelf : IArgumentsBuilder<TSelf>
{
    TSelf AddArgument(string key, object? value);
    TSelf AddArguments(IDictionary<string, object?> arguments);
}

[PublicAPI]
public interface IUnionCasesBuilder<out TSelf> where TSelf : IUnionCasesBuilder<TSelf>
{
    TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery)
        where TUnionCase : class?;
}

[PublicAPI]
public interface IInterfaceCasesBuilder<out TSelf> where TSelf : IInterfaceCasesBuilder<TSelf>
{
    /// <summary>Adds a query fragment for a concrete type implementing the GraphQL interface.</summary>
    /// <typeparam name="TConcreteType">The type which implements the GraphQL interface.</typeparam>
    TSelf AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery)
        where TConcreteType : class?;
}

[PublicAPI]
public interface IFieldsBuilder<out TSelf> : IUnionCasesBuilder<TSelf>, IInterfaceCasesBuilder<TSelf> where TSelf : IFieldsBuilder<TSelf>
{
    TSelf AddField(string field);
    TSelf AddField(IQuery subQuery);
    TSelf AddField<TSubSource>(IQuery<TSubSource> subQuery)
        where TSubSource : class?;
}

[PublicAPI]
public interface IQuery<out TSource> : IQuery, IArgumentsBuilder<IQuery<TSource>>, IFieldsBuilder<IQuery<TSource>>
{
    List<object?> SelectList { get; }
    Dictionary<string, object?> Arguments { get; }
    IQuery<TSource> SetAlias(string alias);
}

[PublicAPI]
public class Query<TSource> : IQuery<TSource>
{
    private const string PolymorphicDiscriminatorKey = "__typename";

    /// <summary>Gets the query string builder.</summary>
    protected IQueryStringBuilder QueryStringBuilder { get; } = new QueryStringBuilder();

    public string QueryName { get; }
    public string? AliasName { get; protected set; }
    public List<object?> SelectList { get; }
    public Dictionary<string, object?> Arguments { get; }

    public Query(string name)
    {
        RequiredArgument.NotNullOrEmpty(name, nameof(name));
        QueryName = name;
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

    public IQuery<TSource> SetAlias(string alias)
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

        // Ensure we also select the __typename polymorphic discriminator key, which is required for deserializing union cases
        if (!unionCaseQuery.SelectList.Contains(PolymorphicDiscriminatorKey))
            SelectList.Add(unionCaseQuery.AddField(PolymorphicDiscriminatorKey));

        return this;
    }

    public IQuery<TSource> AddInterfaceCase<TConcreteType>(IQuery<TConcreteType> concreteTypeQuery) where TConcreteType : class?
    {
        RequiredArgument.NotNull(concreteTypeQuery, nameof(concreteTypeQuery));

        // Ensure we also select the __typename polymorphic discriminator key, which is required for deserializing interface cases
        if (!concreteTypeQuery.SelectList.Contains(PolymorphicDiscriminatorKey))
            SelectList.Add(concreteTypeQuery.AddField(PolymorphicDiscriminatorKey));

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
