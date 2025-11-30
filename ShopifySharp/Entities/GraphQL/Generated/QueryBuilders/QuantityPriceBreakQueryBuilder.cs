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

public class QuantityPriceBreakQueryBuilder() : GraphQueryBuilder<QuantityPriceBreak>("query quantityPriceBreak")
{
    public QuantityPriceBreakQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldMinimumQuantity()
    {
        AddField("minimumQuantity");
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }
}