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

public class ReverseDeliveryQueryBuilder() : GraphQueryBuilder<ReverseDelivery>("query reverseDelivery")
{
    public ReverseDeliveryQueryBuilder AddFieldDeliverable()
    {
        AddField("deliverable");
        return this;
    }

    public ReverseDeliveryQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseDeliveryQueryBuilder AddFieldReverseDeliveryLineItems()
    {
        AddField("reverseDeliveryLineItems");
        return this;
    }

    public ReverseDeliveryQueryBuilder AddFieldReverseFulfillmentOrder()
    {
        AddField("reverseFulfillmentOrder");
        return this;
    }
}