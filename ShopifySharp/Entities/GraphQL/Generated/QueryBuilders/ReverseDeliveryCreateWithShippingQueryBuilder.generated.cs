#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ReverseDeliveryCreateWithShippingQueryBuilder() : GraphQueryBuilder<ReverseDeliveryCreateWithShippingPayload>("reverseDeliveryCreateWithShipping"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ReverseDeliveryCreateWithShippingQueryBuilder AddArgumentLabelInput(ReverseDeliveryLabelInput? labelInput)
    {
        AddArgument("labelInput", labelInput);
        return this;
    }

    public ReverseDeliveryCreateWithShippingQueryBuilder AddArgumentNotifyCustomer(bool? notifyCustomer)
    {
        AddArgument("notifyCustomer", notifyCustomer);
        return this;
    }

    public ReverseDeliveryCreateWithShippingQueryBuilder AddArgumentReverseDeliveryLineItems(ICollection<ReverseDeliveryLineItemInput>? reverseDeliveryLineItems)
    {
        AddArgument("reverseDeliveryLineItems", reverseDeliveryLineItems);
        return this;
    }

    public ReverseDeliveryCreateWithShippingQueryBuilder AddArgumentReverseFulfillmentOrderId(string? reverseFulfillmentOrderId)
    {
        AddArgument("reverseFulfillmentOrderId", reverseFulfillmentOrderId);
        return this;
    }

    public ReverseDeliveryCreateWithShippingQueryBuilder AddArgumentTrackingInput(ReverseDeliveryTrackingInput? trackingInput)
    {
        AddArgument("trackingInput", trackingInput);
        return this;
    }
}