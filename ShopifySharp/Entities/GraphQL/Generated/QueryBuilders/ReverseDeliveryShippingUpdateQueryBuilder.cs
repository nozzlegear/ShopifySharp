#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ReverseDeliveryShippingUpdateQueryBuilder() : GraphQueryBuilder<ReverseDeliveryShippingUpdatePayload>("query reverseDeliveryShippingUpdate")
{
    public ReverseDeliveryShippingUpdateQueryBuilder AddArgumentLabelInput(ReverseDeliveryLabelInput? labelInput)
    {
        AddArgument("labelInput", labelInput);
        return this;
    }

    public ReverseDeliveryShippingUpdateQueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }

    public ReverseDeliveryShippingUpdateQueryBuilder AddArgumentReverseDeliveryId(string? reverseDeliveryId)
    {
        AddArgument("reverseDeliveryId", reverseDeliveryId);
        return this;
    }

    public ReverseDeliveryShippingUpdateQueryBuilder AddArgumentTrackingInput(ReverseDeliveryTrackingInput? trackingInput)
    {
        AddArgument("trackingInput", trackingInput);
        return this;
    }
}