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

public class ReturnableFulfillmentLineItemQueryBuilder() : GraphQueryBuilder<ReturnableFulfillmentLineItem>("returnableFulfillmentLineItem")
{
    public ReturnableFulfillmentLineItemQueryBuilder AddFieldFulfillmentLineItem(Func<FulfillmentLineItemQueryBuilder, FulfillmentLineItemQueryBuilder> build)
    {
        AddField<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>("fulfillmentLineItem", build);
        return this;
    }

    public ReturnableFulfillmentLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}