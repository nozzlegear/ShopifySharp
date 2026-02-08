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
    public sealed class FulfillmentCreateV2ArgumentsBuilder : ArgumentsBuilderBase<FulfillmentCreateV2Payload, FulfillmentCreateV2ArgumentsBuilder>
    {
        protected override FulfillmentCreateV2ArgumentsBuilder Self => this;

        public FulfillmentCreateV2ArgumentsBuilder(IQuery<FulfillmentCreateV2Payload> query) : base(query)
        {
        }

        public FulfillmentCreateV2ArgumentsBuilder Fulfillment(FulfillmentV2Input? fulfillment)
        {
            base.InnerQuery.AddArgument("fulfillment", fulfillment);
            return this;
        }

        public FulfillmentCreateV2ArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }
    }
}