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
    public sealed class WebhookSubscriptionCreatePayloadQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionCreatePayload, WebhookSubscriptionCreatePayloadQueryBuilder>
    {
        protected override WebhookSubscriptionCreatePayloadQueryBuilder Self => this;

        public WebhookSubscriptionCreatePayloadQueryBuilder() : this("webhookSubscriptionCreatePayload")
        {
        }

        public WebhookSubscriptionCreatePayloadQueryBuilder(string name) : base(new Query<WebhookSubscriptionCreatePayload>(name))
        {
        }

        public WebhookSubscriptionCreatePayloadQueryBuilder(IQuery<WebhookSubscriptionCreatePayload> query) : base(query)
        {
        }

        public WebhookSubscriptionCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public WebhookSubscriptionCreatePayloadQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}