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
    public sealed class WebhookPubSubEndpointQueryBuilder : FieldsQueryBuilderBase<WebhookPubSubEndpoint, WebhookPubSubEndpointQueryBuilder>
    {
        protected override WebhookPubSubEndpointQueryBuilder Self => this;

        public WebhookPubSubEndpointQueryBuilder() : this("webhookPubSubEndpoint")
        {
        }

        public WebhookPubSubEndpointQueryBuilder(string name) : base(new Query<WebhookPubSubEndpoint>(name))
        {
        }

        public WebhookPubSubEndpointQueryBuilder(IQuery<WebhookPubSubEndpoint> query) : base(query)
        {
        }

        public WebhookPubSubEndpointQueryBuilder PubSubProject()
        {
            base.InnerQuery.AddField("pubSubProject");
            return this;
        }

        public WebhookPubSubEndpointQueryBuilder PubSubTopic()
        {
            base.InnerQuery.AddField("pubSubTopic");
            return this;
        }
    }
}