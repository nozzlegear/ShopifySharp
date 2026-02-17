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
    public sealed class WebPresenceUpdateOperationQueryBuilder : FieldsQueryBuilderBase<WebPresenceUpdatePayload, WebPresenceUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<WebPresenceUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebPresenceUpdateArgumentsBuilder Arguments { get; }
        protected override WebPresenceUpdateOperationQueryBuilder Self => this;

        public WebPresenceUpdateOperationQueryBuilder() : this("webPresenceUpdate")
        {
        }

        public WebPresenceUpdateOperationQueryBuilder(string name) : base(new Query<WebPresenceUpdatePayload>(name))
        {
            Arguments = new WebPresenceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public WebPresenceUpdateOperationQueryBuilder(IQuery<WebPresenceUpdatePayload> query) : base(query)
        {
            Arguments = new WebPresenceUpdateArgumentsBuilder(base.InnerQuery);
        }

        public WebPresenceUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }

        public WebPresenceUpdateOperationQueryBuilder WebPresence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("webPresence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }
    }
}