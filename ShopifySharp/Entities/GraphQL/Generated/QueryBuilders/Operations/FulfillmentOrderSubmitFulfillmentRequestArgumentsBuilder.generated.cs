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
    public sealed class FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder : ArgumentsBuilderBase<FulfillmentOrderSubmitFulfillmentRequestPayload, FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder>
    {
        protected override FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder Self => this;

        public FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder(IQuery<FulfillmentOrderSubmitFulfillmentRequestPayload> query) : base(query)
        {
        }

        public FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder FulfillmentOrderLineItems(ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems)
        {
            base.InnerQuery.AddArgument("fulfillmentOrderLineItems", fulfillmentOrderLineItems);
            return this;
        }

        public FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder Message(string? message)
        {
            base.InnerQuery.AddArgument("message", message);
            return this;
        }

        public FulfillmentOrderSubmitFulfillmentRequestArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }
    }
}