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
    public sealed class WebhookHttpEndpointQueryBuilder : FieldsQueryBuilderBase<WebhookHttpEndpoint, WebhookHttpEndpointQueryBuilder>
    {
        protected override WebhookHttpEndpointQueryBuilder Self => this;

        public WebhookHttpEndpointQueryBuilder() : this("webhookHttpEndpoint")
        {
        }

        public WebhookHttpEndpointQueryBuilder(string name) : base(new Query<WebhookHttpEndpoint>(name))
        {
        }

        public WebhookHttpEndpointQueryBuilder(IQuery<WebhookHttpEndpoint> query) : base(query)
        {
        }

        public WebhookHttpEndpointQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }
    }
}