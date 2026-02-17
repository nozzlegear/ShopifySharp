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
    public sealed class FulfillmentTrackingInfoUpdateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentTrackingInfoUpdatePayload, FulfillmentTrackingInfoUpdateArgumentsBuilder>
    {
        protected override FulfillmentTrackingInfoUpdateArgumentsBuilder Self => this;

        public FulfillmentTrackingInfoUpdateArgumentsBuilder(IQuery<FulfillmentTrackingInfoUpdatePayload> query) : base(query)
        {
        }

        public FulfillmentTrackingInfoUpdateArgumentsBuilder FulfillmentId(string? fulfillmentId)
        {
            base.InnerQuery.AddArgument("fulfillmentId", fulfillmentId);
            return this;
        }

        public FulfillmentTrackingInfoUpdateArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }

        public FulfillmentTrackingInfoUpdateArgumentsBuilder TrackingInfoInput(FulfillmentTrackingInput? trackingInfoInput)
        {
            base.InnerQuery.AddArgument("trackingInfoInput", trackingInfoInput);
            return this;
        }
    }
}