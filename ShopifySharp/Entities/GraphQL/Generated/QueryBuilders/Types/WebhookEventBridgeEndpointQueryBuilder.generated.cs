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
    public sealed class WebhookEventBridgeEndpointQueryBuilder : FieldsQueryBuilderBase<WebhookEventBridgeEndpoint, WebhookEventBridgeEndpointQueryBuilder>
    {
        protected override WebhookEventBridgeEndpointQueryBuilder Self => this;

        public WebhookEventBridgeEndpointQueryBuilder() : this("webhookEventBridgeEndpoint")
        {
        }

        public WebhookEventBridgeEndpointQueryBuilder(string name) : base(new Query<WebhookEventBridgeEndpoint>(name))
        {
        }

        public WebhookEventBridgeEndpointQueryBuilder(IQuery<WebhookEventBridgeEndpoint> query) : base(query)
        {
        }

        public WebhookEventBridgeEndpointQueryBuilder Arn()
        {
            base.InnerQuery.AddField("arn");
            return this;
        }
    }
}