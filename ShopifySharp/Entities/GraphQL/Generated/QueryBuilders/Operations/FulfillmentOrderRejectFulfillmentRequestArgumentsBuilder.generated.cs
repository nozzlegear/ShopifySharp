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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderRejectFulfillmentRequestPayload, FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder>
    {
        protected override FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder Self => this;

        public FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder(IQuery<FulfillmentOrderRejectFulfillmentRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder LineItems(ICollection<IncomingRequestLineItemInput>? lineItems)
        {
            base.InnerQuery.AddArgument("lineItems", lineItems);
            return this;
        }

        public FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }

        public FulfillmentOrderRejectFulfillmentRequestArgumentsBuilder Reason(FulfillmentOrderRejectionReason? reason)
        {
            base.InnerQuery.AddArgument("reason", reason);
            return this;
        }
    }
}