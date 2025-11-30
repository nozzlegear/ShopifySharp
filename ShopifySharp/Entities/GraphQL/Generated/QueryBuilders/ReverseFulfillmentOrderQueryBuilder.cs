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

public class ReverseFulfillmentOrderQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrder>("query reverseFulfillmentOrder")
{
    public ReverseFulfillmentOrderQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldReverseDeliveries()
    {
        AddField("reverseDeliveries");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldThirdPartyConfirmation()
    {
        AddField("thirdPartyConfirmation");
        return this;
    }
}