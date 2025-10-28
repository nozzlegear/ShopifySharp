#nullable enable
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>(string name) : IQuery<T>
    where T: IGraphQLObject
{
    protected IQuery<T> Query { get; set; } = new Query<T>(name);

    public string Name { get; }
    public string? AliasName { get; }

    /// <summary>
    /// Builds the query.
    /// </summary>
    public string Build()
    {
        return Query.Build();
    }

    public List<object?> SelectList { get; }
    public Dictionary<string, object?> Arguments { get; }
    IQuery<T> IQuery<T>.Alias(string alias)
    {
        return Alias(alias);
    }

    public IQuery<T> AddField<TProperty>(Expression<Func<T, TProperty>> selector)
    {
        throw new NotImplementedException();
    }

    IQuery<T> IQuery<T>.AddField(string field)
    {
        return AddField(field);
    }

    public IQuery<T> AddField<TSubSource>(Expression<Func<T, TSubSource>> selector, Func<IQuery<TSubSource>, IQuery<TSubSource>> build) where TSubSource : class?
    {
        throw new NotImplementedException();
    }

    public IQuery<T> AddField<TSubSource>(Expression<Func<T, IEnumerable<TSubSource>>> selector, Func<IQuery<TSubSource>, IQuery<TSubSource>> build) where TSubSource : class?
    {
        throw new NotImplementedException();
    }

    IQuery<T> IQuery<T>.AddField<TSubSource>(string field, Func<IQuery<TSubSource>, IQuery<TSubSource>> build)
    {
        return AddField(field, build);
    }

    IQuery<T> IQuery<T>.AddUnion<TUnionType>(string typeName, Func<IQuery<TUnionType>, IQuery<TUnionType>> build)
    {
        return AddUnion(typeName, build);
    }

    public IQuery<T> AddUnionX<TUnionType>(string typeName, Func<IQuery<TUnionType>, IQuery<TUnionType>> build) where TUnionType : class?, IGraphQLUnionCase
    {
        throw new NotImplementedException();
    }

    public IQuery<T> AddUnionX2<TUnionCase>(string name, Func<IQuery<TUnionCase>, IQuery<TUnionCase>> customize) where TUnionCase : class?, IGraphQLUnionCase, IGraphQLObject
    {
        throw new NotImplementedException();
    }

    public IQuery<T> AddUnion<TUnionType>(Func<IQuery<TUnionType>, IQuery<TUnionType>> build) where TUnionType : class?, T
    {
        throw new NotImplementedException();
    }

    IQuery<T> IQuery<T>.AddArgument(string key, object? value)
    {
        return AddArgument(key, value);
    }

    IQuery<T> IQuery<T>.AddArguments(Dictionary<string, object?> arguments)
    {
        return AddArguments(arguments);
    }

    IQuery<T> IQuery<T>.AddArguments<TArguments>(TArguments arguments)
    {
        return AddArguments(arguments);
    }

    public GraphQueryBuilder<T> Alias(string alias)
    {
        Query = Query.Alias(alias);
        return this;
    }

    public GraphQueryBuilder<T> AddArgument(string key, object? value)
    {
        Query = Query.AddArgument(key, value);
        return this;
    }

    public GraphQueryBuilder<T> AddArguments(Dictionary<string, object?> arguments)
    {
        Query = Query.AddArguments(arguments);
        return this;
    }

    public GraphQueryBuilder<T> AddArguments<TArguments>(TArguments arguments) where TArguments : class
    {
        Query = Query.AddArguments(arguments);
        return this;
    }

    public GraphQueryBuilder<T> AddField(string name)
    {
        Query = Query.AddField(name);
        return this;
    }

    public GraphQueryBuilder<T> AddField<TField>(string name, System.Func<IQuery<TField>, IQuery<TField>> customize) where TField: class, IGraphQLObject
    {
        Query = Query.AddField(name, customize);
        return this;
    }

    public GraphQueryBuilder<T> AddUnion<TUnionCase>(string name, System.Func<IQuery<TUnionCase>, IQuery<TUnionCase>> customize) where TUnionCase : class, T
    {
        Query = Query.AddUnion(name, customize);
        return this;
    }

    public GraphQueryBuilder<T> AddUnionX<TUnionCase>(string name, System.Func<GraphQueryBuilder<TUnionCase>, GraphQueryBuilder<TUnionCase>> customize)
        where TUnionCase : class, IGraphQLUnionCase, IGraphQLObject
    {
        Query = Query.AddUnionX2<TUnionCase>(name, customize);
        return this;
    }
}
