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
    public sealed class PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<PubSubWebhookSubscriptionUpdateUserError, PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder>
    {
        protected override PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder Self => this;

        public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder() : this("pubSubWebhookSubscriptionUpdateUserError")
        {
        }

        public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder(string name) : base(new Query<PubSubWebhookSubscriptionUpdateUserError>(name))
        {
        }

        public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder(IQuery<PubSubWebhookSubscriptionUpdateUserError> query) : base(query)
        {
        }

        public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}