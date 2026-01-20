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
        InnerQuery.AddField(subQuery);
        return Self;
    }

    public TSelf AddField(IQuery subQuery)
    {
        InnerQuery.AddField(subQuery);
        return Self;
    }

    public TSelf AddField(string field)
    {
        InnerQuery.AddField(field);
        return Self;
    }

    public TSelf AddUnionCase<TUnionCase>(IQuery<TUnionCase> unionCaseQuery)
        where TUnionCase : class?
    {
        InnerQuery.AddUnionCase(unionCaseQuery);
        return Self;
    }
}
