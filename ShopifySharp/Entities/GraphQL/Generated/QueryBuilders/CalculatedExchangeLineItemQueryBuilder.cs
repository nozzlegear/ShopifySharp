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

public class CalculatedExchangeLineItemQueryBuilder() : GraphQueryBuilder<CalculatedExchangeLineItem>("query calculatedExchangeLineItem")
{
    public CalculatedExchangeLineItemQueryBuilder AddFieldCalculatedDiscountAllocations()
    {
        AddField("calculatedDiscountAllocations");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldSubtotalSet()
    {
        AddField("subtotalSet");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldTotalTaxSet()
    {
        AddField("totalTaxSet");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }
}