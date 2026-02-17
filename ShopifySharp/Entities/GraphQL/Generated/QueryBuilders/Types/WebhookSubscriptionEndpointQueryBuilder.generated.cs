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
    public sealed class WebhookSubscriptionEndpointQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionEndpoint, WebhookSubscriptionEndpointQueryBuilder>
    {
        protected override WebhookSubscriptionEndpointQueryBuilder Self => this;

        public WebhookSubscriptionEndpointQueryBuilder() : this("webhookSubscriptionEndpoint")
        {
        }

        public WebhookSubscriptionEndpointQueryBuilder(string name) : base(new Query<WebhookSubscriptionEndpoint>(name))
        {
        }

        public WebhookSubscriptionEndpointQueryBuilder(IQuery<WebhookSubscriptionEndpoint> query) : base(query)
        {
        }

        public WebhookSubscriptionEndpointQueryBuilder WebhookSubscriptionEndpoint(Action<WebhookSubscriptionEndpointUnionCasesBuilder> build)
        {
            var query = new Query<WebhookSubscriptionEndpoint>("webhookSubscriptionEndpoint");
            var unionBuilder = new WebhookSubscriptionEndpointUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}