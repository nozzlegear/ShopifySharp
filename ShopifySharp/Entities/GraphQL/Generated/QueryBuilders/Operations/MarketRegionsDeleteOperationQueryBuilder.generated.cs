#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    [Obsolete("Use `marketUpdate` instead.")]
    public sealed class MarketRegionsDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MarketRegionsDeletePayload, MarketRegionsDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketRegionsDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketRegionsDeleteArgumentsBuilder Arguments { get; }
        protected override MarketRegionsDeleteOperationQueryBuilder Self => this;

        public MarketRegionsDeleteOperationQueryBuilder() : this("marketRegionsDelete")
        {
        }

        public MarketRegionsDeleteOperationQueryBuilder(string name) : base(new Query<MarketRegionsDeletePayload>(name))
        {
            Arguments = new MarketRegionsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionsDeleteOperationQueryBuilder(IQuery<MarketRegionsDeletePayload> query) : base(query)
        {
            Arguments = new MarketRegionsDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionsDeleteOperationQueryBuilder DeletedIds()
        {
            base.InnerQuery.AddField("deletedIds");
            return this;
        }

        public MarketRegionsDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}