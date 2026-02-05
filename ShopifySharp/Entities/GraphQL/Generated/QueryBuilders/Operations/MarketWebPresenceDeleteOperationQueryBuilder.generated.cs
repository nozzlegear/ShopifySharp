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
    [Obsolete("Use `webPresenceDelete` instead.")]
    public sealed class MarketWebPresenceDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceDeletePayload, MarketWebPresenceDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketWebPresenceDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketWebPresenceDeleteArgumentsBuilder Arguments { get; }
        protected override MarketWebPresenceDeleteOperationQueryBuilder Self => this;

        public MarketWebPresenceDeleteOperationQueryBuilder() : this("marketWebPresenceDelete")
        {
        }

        public MarketWebPresenceDeleteOperationQueryBuilder(string name) : base(new Query<MarketWebPresenceDeletePayload>(name))
        {
            Arguments = new MarketWebPresenceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresenceDeleteOperationQueryBuilder(IQuery<MarketWebPresenceDeletePayload> query) : base(query)
        {
            Arguments = new MarketWebPresenceDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresenceDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MarketWebPresenceDeleteOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketWebPresenceDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}