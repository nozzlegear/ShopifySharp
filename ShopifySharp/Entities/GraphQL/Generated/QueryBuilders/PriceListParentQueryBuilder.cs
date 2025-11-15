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

public class PriceListParentQueryBuilder() : GraphQueryBuilder<PriceListParent>("query priceListParent")
{
    public PriceListParentQueryBuilder AddFieldAdjustment()
    {
        AddField("adjustment");
        return this;
    }

    public PriceListParentQueryBuilder AddFieldSettings()
    {
        AddField("settings");
        return this;
    }
}