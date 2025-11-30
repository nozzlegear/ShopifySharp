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

public class ReverseDeliveryShippingDeliverableQueryBuilder() : GraphQueryBuilder<ReverseDeliveryShippingDeliverable>("query reverseDeliveryShippingDeliverable")
{
    public ReverseDeliveryShippingDeliverableQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }

    public ReverseDeliveryShippingDeliverableQueryBuilder AddFieldTracking()
    {
        AddField("tracking");
        return this;
    }
}