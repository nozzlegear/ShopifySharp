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
    public sealed class PubSubWebhookSubscriptionUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<PubSubWebhookSubscriptionUpdatePayload, PubSubWebhookSubscriptionUpdatePayloadQueryBuilder>
    {
        protected override PubSubWebhookSubscriptionUpdatePayloadQueryBuilder Self => this;

        public PubSubWebhookSubscriptionUpdatePayloadQueryBuilder() : this("pubSubWebhookSubscriptionUpdatePayload")
        {
        }

        public PubSubWebhookSubscriptionUpdatePayloadQueryBuilder(string name) : base(new Query<PubSubWebhookSubscriptionUpdatePayload>(name))
        {
        }

        public PubSubWebhookSubscriptionUpdatePayloadQueryBuilder(IQuery<PubSubWebhookSubscriptionUpdatePayload> query) : base(query)
        {
        }

        public PubSubWebhookSubscriptionUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PubSubWebhookSubscriptionUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PubSubWebhookSubscriptionUpdateUserError>(query);
            return this;
        }

        public PubSubWebhookSubscriptionUpdatePayloadQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}