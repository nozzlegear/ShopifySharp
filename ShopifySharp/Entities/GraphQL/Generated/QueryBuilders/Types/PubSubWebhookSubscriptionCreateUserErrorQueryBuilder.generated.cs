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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class PubSubWebhookSubscriptionCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<PubSubWebhookSubscriptionCreateUserError, PubSubWebhookSubscriptionCreateUserErrorQueryBuilder>
    {
        protected override PubSubWebhookSubscriptionCreateUserErrorQueryBuilder Self => this;

        public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder() : this("pubSubWebhookSubscriptionCreateUserError")
        {
        }

        public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder(string name) : base(new Query<PubSubWebhookSubscriptionCreateUserError>(name))
        {
        }

        public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder(IQuery<PubSubWebhookSubscriptionCreateUserError> query) : base(query)
        {
        }

        public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}