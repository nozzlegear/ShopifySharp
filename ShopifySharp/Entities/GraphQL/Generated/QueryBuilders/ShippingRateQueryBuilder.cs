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

public class ShippingRateQueryBuilder() : GraphQueryBuilder<ShippingRate>("query shippingRate")
{
    public ShippingRateQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public ShippingRateQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public ShippingRateQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}