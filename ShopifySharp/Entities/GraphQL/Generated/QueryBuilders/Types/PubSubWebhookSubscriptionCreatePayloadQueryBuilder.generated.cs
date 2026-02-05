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
    public sealed class PubSubWebhookSubscriptionCreatePayloadQueryBuilder : FieldsQueryBuilderBase<PubSubWebhookSubscriptionCreatePayload, PubSubWebhookSubscriptionCreatePayloadQueryBuilder>
    {
        protected override PubSubWebhookSubscriptionCreatePayloadQueryBuilder Self => this;

        public PubSubWebhookSubscriptionCreatePayloadQueryBuilder() : this("pubSubWebhookSubscriptionCreatePayload")
        {
        }

        public PubSubWebhookSubscriptionCreatePayloadQueryBuilder(string name) : base(new Query<PubSubWebhookSubscriptionCreatePayload>(name))
        {
        }

        public PubSubWebhookSubscriptionCreatePayloadQueryBuilder(IQuery<PubSubWebhookSubscriptionCreatePayload> query) : base(query)
        {
        }

        public PubSubWebhookSubscriptionCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PubSubWebhookSubscriptionCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PubSubWebhookSubscriptionCreateUserError>(query);
            return this;
        }

        public PubSubWebhookSubscriptionCreatePayloadQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}