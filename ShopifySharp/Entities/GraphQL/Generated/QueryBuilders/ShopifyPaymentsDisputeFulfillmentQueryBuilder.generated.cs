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

public class ShopifyPaymentsDisputeFulfillmentQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDisputeFulfillment>("shopifyPaymentsDisputeFulfillment")
{
    public ShopifyPaymentsDisputeFulfillmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsDisputeFulfillmentQueryBuilder AddFieldShippingCarrier()
    {
        AddField("shippingCarrier");
        return this;
    }

    public ShopifyPaymentsDisputeFulfillmentQueryBuilder AddFieldShippingDate()
    {
        AddField("shippingDate");
        return this;
    }

    public ShopifyPaymentsDisputeFulfillmentQueryBuilder AddFieldShippingTrackingNumber()
    {
        AddField("shippingTrackingNumber");
        return this;
    }
}