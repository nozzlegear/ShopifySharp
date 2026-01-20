#nullable enable
using JetBrains.Annotations;
using ShopifySharp.GraphQL;

namespace ShopifySharp.Infrastructure;

[PublicAPI]
public abstract class FieldsQueryBuilder<T, TSelf> : QueryBuilder<T, TSelf>, IFieldsBuilder<TSelf>
    where T: IGraphQLObject
    where TSelf : QueryBuilder<T, TSelf>, IFieldsBuilder<TSelf>
{
    protected FieldsQueryBuilder(IQuery<T> query) : base(query)
    {
    }

    public TSelf AddField<TSubSource>(IQuery<TSubSource> subQuery)
        where TSubSource : class?
    {
        Query.AddField(subQuery);
        return Self;
    }

    public TSelf AddField(IQuery subQuery)
    {
        Query.AddField(subQuery);
        return Self;
    }

    public TSelf AddField(string field)
    {
        Query.AddField(field);
        return Self;
    }

    public TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery)
        where TUnionCase : class?
    {
        Query.AddUnionCase(unionCaseQuery);
        return Self;
    }
}