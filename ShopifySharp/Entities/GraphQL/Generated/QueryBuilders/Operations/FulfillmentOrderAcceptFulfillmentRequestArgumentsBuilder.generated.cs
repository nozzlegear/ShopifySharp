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
    public sealed class FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderAcceptFulfillmentRequestPayload, FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder>
    {
        protected override FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder Self => this;

        public FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder(IQuery<FulfillmentOrderAcceptFulfillmentRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder EstimatedShippedAt(DateTimeOffset? estimatedShippedAt)
        {
            base.InnerQuery.AddArgument("estimatedShippedAt", estimatedShippedAt);
            return this;
        }

        public FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderAcceptFulfillmentRequestArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}