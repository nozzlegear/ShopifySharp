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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class WebhookSubscriptionsCountArgumentsBuilder : ArgumentsBuilderBase<Count, WebhookSubscriptionsCountArgumentsBuilder>
    {
        protected override WebhookSubscriptionsCountArgumentsBuilder Self => this;

        public WebhookSubscriptionsCountArgumentsBuilder(IQuery<Count> query) : base(query)
        {
        }

        public WebhookSubscriptionsCountArgumentsBuilder Limit(int? limit)
        {
            base.InnerQuery.AddArgument("limit", limit);
            return this;
        }

        public WebhookSubscriptionsCountArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}