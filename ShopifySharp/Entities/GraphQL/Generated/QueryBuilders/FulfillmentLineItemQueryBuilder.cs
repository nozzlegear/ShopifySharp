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

public class FulfillmentLineItemQueryBuilder() : GraphQueryBuilder<FulfillmentLineItem>("query fulfillmentLineItem")
{
    [Obsolete("Use `discountedTotalSet` instead.")]
    public FulfillmentLineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldDiscountedTotalSet()
    {
        AddField("discountedTotalSet");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    [Obsolete("Use `originalTotalSet` instead.")]
    public FulfillmentLineItemQueryBuilder AddFieldOriginalTotal()
    {
        AddField("originalTotal");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldOriginalTotalSet()
    {
        AddField("originalTotalSet");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}