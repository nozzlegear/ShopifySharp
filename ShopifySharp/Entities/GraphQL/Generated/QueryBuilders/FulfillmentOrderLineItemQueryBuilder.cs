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

public class FulfillmentOrderLineItemQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItem>("query fulfillmentOrderLineItem")
{
    public FulfillmentOrderLineItemQueryBuilder AddFieldFinancialSummaries()
    {
        AddField("financialSummaries");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldInventoryItemId()
    {
        AddField("inventoryItemId");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    [Obsolete("Use `financialSummaries` instead.")]
    public FulfillmentOrderLineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldProductTitle()
    {
        AddField("productTitle");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldRemainingQuantity()
    {
        AddField("remainingQuantity");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldVendor()
    {
        AddField("vendor");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldWarnings()
    {
        AddField("warnings");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}