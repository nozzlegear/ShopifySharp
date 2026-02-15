#nullable enable
using JetBrains.Annotations;
using ShopifySharp.GraphQL;

namespace ShopifySharp.GraphQL.QueryBuilders;

[PublicAPI]
public abstract class FieldsQueryBuilderBase<T, TSelf> : QueryBuilderBase<T, TSelf>, IFieldsBuilder<TSelf>
    where T: IGraphQLObject
    where TSelf : QueryBuilderBase<T, TSelf>, IFieldsBuilder<TSelf>
{
    protected FieldsQueryBuilderBase(IQuery<T> query) : base(query)
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
