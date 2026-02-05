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
    public sealed class FulfillmentTrackingInfoUpdateV2ArgumentsBuilder : ArgumentsBuilderBase<FulfillmentTrackingInfoUpdateV2Payload, FulfillmentTrackingInfoUpdateV2ArgumentsBuilder>
    {
        protected override FulfillmentTrackingInfoUpdateV2ArgumentsBuilder Self => this;

        public FulfillmentTrackingInfoUpdateV2ArgumentsBuilder(IQuery<FulfillmentTrackingInfoUpdateV2Payload> query) : base(query)
        {
        }

        public FulfillmentTrackingInfoUpdateV2ArgumentsBuilder FulfillmentId(string? fulfillmentId)
        {
            base.InnerQuery.AddArgument("fulfillmentId", fulfillmentId);
            return this;
        }

        public FulfillmentTrackingInfoUpdateV2ArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }

        public FulfillmentTrackingInfoUpdateV2ArgumentsBuilder TrackingInfoInput(FulfillmentTrackingInput? trackingInfoInput)
        {
            base.InnerQuery.AddArgument("trackingInfoInput", trackingInfoInput);
            return this;
        }
    }
}