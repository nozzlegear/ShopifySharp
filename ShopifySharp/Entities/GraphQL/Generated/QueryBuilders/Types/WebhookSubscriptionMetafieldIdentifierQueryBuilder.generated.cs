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
    public sealed class WebhookSubscriptionMetafieldIdentifierQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionMetafieldIdentifier, WebhookSubscriptionMetafieldIdentifierQueryBuilder>
    {
        protected override WebhookSubscriptionMetafieldIdentifierQueryBuilder Self => this;

        public WebhookSubscriptionMetafieldIdentifierQueryBuilder() : this("webhookSubscriptionMetafieldIdentifier")
        {
        }

        public WebhookSubscriptionMetafieldIdentifierQueryBuilder(string name) : base(new Query<WebhookSubscriptionMetafieldIdentifier>(name))
        {
        }

        public WebhookSubscriptionMetafieldIdentifierQueryBuilder(IQuery<WebhookSubscriptionMetafieldIdentifier> query) : base(query)
        {
        }

        public WebhookSubscriptionMetafieldIdentifierQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public WebhookSubscriptionMetafieldIdentifierQueryBuilder Namespace()
        {
            base.InnerQuery.AddField("namespace");
            return this;
        }
    }
}