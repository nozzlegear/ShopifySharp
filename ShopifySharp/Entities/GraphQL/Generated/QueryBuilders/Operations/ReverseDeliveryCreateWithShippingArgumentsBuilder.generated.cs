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
    public sealed class ReverseDeliveryCreateWithShippingArgumentsBuilder : ArgumentsBuilderBase<ReverseDeliveryCreateWithShippingPayload, ReverseDeliveryCreateWithShippingArgumentsBuilder>
    {
        protected override ReverseDeliveryCreateWithShippingArgumentsBuilder Self => this;

        public ReverseDeliveryCreateWithShippingArgumentsBuilder(IQuery<ReverseDeliveryCreateWithShippingPayload> query) : base(query)
        {
        }

        public ReverseDeliveryCreateWithShippingArgumentsBuilder LabelInput(ReverseDeliveryLabelInput? labelInput)
        {
            base.InnerQuery.AddArgument("labelInput", labelInput);
            return this;
        }

        public ReverseDeliveryCreateWithShippingArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }

        public ReverseDeliveryCreateWithShippingArgumentsBuilder ReverseDeliveryLineItems(ICollection<ReverseDeliveryLineItemInput>? reverseDeliveryLineItems)
        {
            base.InnerQuery.AddArgument("reverseDeliveryLineItems", reverseDeliveryLineItems);
            return this;
        }

        public ReverseDeliveryCreateWithShippingArgumentsBuilder ReverseFulfillmentOrderId(string? reverseFulfillmentOrderId)
        {
            base.InnerQuery.AddArgument("reverseFulfillmentOrderId", reverseFulfillmentOrderId);
            return this;
        }

        public ReverseDeliveryCreateWithShippingArgumentsBuilder TrackingInput(ReverseDeliveryTrackingInput? trackingInput)
        {
            base.InnerQuery.AddArgument("trackingInput", trackingInput);
            return this;
        }
    }
}