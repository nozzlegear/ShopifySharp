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