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

public class ReverseFulfillmentOrderLineItemQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderLineItem>("query reverseFulfillmentOrderLineItem")
{
    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldDispositions()
    {
        AddField("dispositions");
        return this;
    }

    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldFulfillmentLineItem()
    {
        AddField("fulfillmentLineItem");
        return this;
    }

    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }
}