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
    [Obsolete("Use `webPresenceCreate` instead.")]
    public sealed class MarketWebPresenceCreateOperationQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceCreatePayload, MarketWebPresenceCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketWebPresenceCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketWebPresenceCreateArgumentsBuilder Arguments { get; }
        protected override MarketWebPresenceCreateOperationQueryBuilder Self => this;

        public MarketWebPresenceCreateOperationQueryBuilder() : this("marketWebPresenceCreate")
        {
        }

        public MarketWebPresenceCreateOperationQueryBuilder(string name) : base(new Query<MarketWebPresenceCreatePayload>(name))
        {
            Arguments = new MarketWebPresenceCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresenceCreateOperationQueryBuilder(IQuery<MarketWebPresenceCreatePayload> query) : base(query)
        {
            Arguments = new MarketWebPresenceCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresenceCreateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketWebPresenceCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}