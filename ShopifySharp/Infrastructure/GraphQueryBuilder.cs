#nullable enable
using System.Collections.Generic;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

public abstract class GraphQueryBuilder<T>(string name) where T: IGraphQLObject
{
    protected IQuery<T> Query { get; set; } = new Query<T>(name);

    /// <summary>
    /// Builds the query.
    /// </summary>
    public string Build()
    {
        return Query.Build();
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
}
