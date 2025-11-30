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

public class ReverseDeliveryLineItemQueryBuilder() : GraphQueryBuilder<ReverseDeliveryLineItem>("query reverseDeliveryLineItem")
{
    public ReverseDeliveryLineItemQueryBuilder AddFieldDispositions()
    {
        AddField("dispositions");
        return this;
    }

    public ReverseDeliveryLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseDeliveryLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ReverseDeliveryLineItemQueryBuilder AddFieldReverseFulfillmentOrderLineItem()
    {
        AddField("reverseFulfillmentOrderLineItem");
        return this;
    }
}