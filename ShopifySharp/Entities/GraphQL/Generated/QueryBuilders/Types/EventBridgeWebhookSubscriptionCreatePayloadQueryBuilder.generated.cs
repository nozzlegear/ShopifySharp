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
    public sealed class EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder : FieldsQueryBuilderBase<EventBridgeWebhookSubscriptionCreatePayload, EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder>
    {
        protected override EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder Self => this;

        public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder() : this("eventBridgeWebhookSubscriptionCreatePayload")
        {
        }

        public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder(string name) : base(new Query<EventBridgeWebhookSubscriptionCreatePayload>(name))
        {
        }

        public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder(IQuery<EventBridgeWebhookSubscriptionCreatePayload> query) : base(query)
        {
        }

        public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}