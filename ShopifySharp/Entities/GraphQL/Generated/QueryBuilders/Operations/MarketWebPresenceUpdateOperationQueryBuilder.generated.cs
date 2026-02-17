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
    [Obsolete("Use `webPresenceUpdate` instead.")]
    public sealed class MarketWebPresenceUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceUpdatePayload, MarketWebPresenceUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketWebPresenceUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketWebPresenceUpdateArgumentsBuilder Arguments { get; }
        protected override MarketWebPresenceUpdateOperationQueryBuilder Self => this;

        public MarketWebPresenceUpdateOperationQueryBuilder() : this("marketWebPresenceUpdate")
        {
        }

        public MarketWebPresenceUpdateOperationQueryBuilder(string name) : base(new Query<MarketWebPresenceUpdatePayload>(name))
        {
            Arguments = new MarketWebPresenceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresenceUpdateOperationQueryBuilder(IQuery<MarketWebPresenceUpdatePayload> query) : base(query)
        {
            Arguments = new MarketWebPresenceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketWebPresenceUpdateOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketWebPresenceUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}