#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    [Obsolete("Use `marketUpdate` instead.")]
    public sealed class MarketRegionDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MarketRegionDeletePayload, MarketRegionDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketRegionDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketRegionDeleteArgumentsBuilder Arguments { get; }
        protected override MarketRegionDeleteOperationQueryBuilder Self => this;

        public MarketRegionDeleteOperationQueryBuilder() : this("marketRegionDelete")
        {
        }

        public MarketRegionDeleteOperationQueryBuilder(string name) : base(new Query<MarketRegionDeletePayload>(name))
        {
            Arguments = new MarketRegionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionDeleteOperationQueryBuilder(IQuery<MarketRegionDeletePayload> query) : base(query)
        {
            Arguments = new MarketRegionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MarketRegionDeleteOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketRegionDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}