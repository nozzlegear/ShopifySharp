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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class WebPresenceUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<WebPresenceUpdatePayload, WebPresenceUpdatePayloadQueryBuilder>
    {
        protected override WebPresenceUpdatePayloadQueryBuilder Self => this;

        public WebPresenceUpdatePayloadQueryBuilder() : this("webPresenceUpdatePayload")
        {
        }

        public WebPresenceUpdatePayloadQueryBuilder(string name) : base(new Query<WebPresenceUpdatePayload>(name))
        {
        }

        public WebPresenceUpdatePayloadQueryBuilder(IQuery<WebPresenceUpdatePayload> query) : base(query)
        {
        }

        public WebPresenceUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }

        public WebPresenceUpdatePayloadQueryBuilder WebPresence(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("webPresence");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }
    }
}