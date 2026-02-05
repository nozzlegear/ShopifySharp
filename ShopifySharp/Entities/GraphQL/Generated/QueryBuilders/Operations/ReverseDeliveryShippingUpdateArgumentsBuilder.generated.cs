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
    public sealed class ReverseDeliveryShippingUpdateArgumentsBuilder : ArgumentsBuilderBase<ReverseDeliveryShippingUpdatePayload, ReverseDeliveryShippingUpdateArgumentsBuilder>
    {
        protected override ReverseDeliveryShippingUpdateArgumentsBuilder Self => this;

        public ReverseDeliveryShippingUpdateArgumentsBuilder(IQuery<ReverseDeliveryShippingUpdatePayload> query) : base(query)
        {
        }

        public ReverseDeliveryShippingUpdateArgumentsBuilder LabelInput(ReverseDeliveryLabelInput? labelInput)
        {
            base.InnerQuery.AddArgument("labelInput", labelInput);
            return this;
        }

        public ReverseDeliveryShippingUpdateArgumentsBuilder NotifyCustomer(bool? notifyCustomer)
        {
            base.InnerQuery.AddArgument("notifyCustomer", notifyCustomer);
            return this;
        }

        public ReverseDeliveryShippingUpdateArgumentsBuilder ReverseDeliveryId(string? reverseDeliveryId)
        {
            base.InnerQuery.AddArgument("reverseDeliveryId", reverseDeliveryId);
            return this;
        }

        public ReverseDeliveryShippingUpdateArgumentsBuilder TrackingInput(ReverseDeliveryTrackingInput? trackingInput)
        {
            base.InnerQuery.AddArgument("trackingInput", trackingInput);
            return this;
        }
    }
}