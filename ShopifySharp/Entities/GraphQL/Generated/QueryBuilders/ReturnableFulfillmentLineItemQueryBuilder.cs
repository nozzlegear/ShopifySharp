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

public class ReturnableFulfillmentLineItemQueryBuilder() : GraphQueryBuilder<ReturnableFulfillmentLineItem>("query returnableFulfillmentLineItem")
{
    public ReturnableFulfillmentLineItemQueryBuilder AddFieldFulfillmentLineItem()
    {
        AddField("fulfillmentLineItem");
        return this;
    }

    public ReturnableFulfillmentLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}