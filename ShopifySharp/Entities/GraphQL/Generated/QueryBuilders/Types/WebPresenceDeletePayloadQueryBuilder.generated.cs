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
    public sealed class WebPresenceDeletePayloadQueryBuilder : FieldsQueryBuilderBase<WebPresenceDeletePayload, WebPresenceDeletePayloadQueryBuilder>
    {
        protected override WebPresenceDeletePayloadQueryBuilder Self => this;

        public WebPresenceDeletePayloadQueryBuilder() : this("webPresenceDeletePayload")
        {
        }

        public WebPresenceDeletePayloadQueryBuilder(string name) : base(new Query<WebPresenceDeletePayload>(name))
        {
        }

        public WebPresenceDeletePayloadQueryBuilder(IQuery<WebPresenceDeletePayload> query) : base(query)
        {
        }

        public WebPresenceDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public WebPresenceDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}