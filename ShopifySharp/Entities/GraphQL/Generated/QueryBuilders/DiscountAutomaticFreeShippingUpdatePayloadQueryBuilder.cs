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

public class DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticFreeShippingUpdatePayload>("query discountAutomaticFreeShippingUpdatePayload")
{
    public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder AddFieldAutomaticDiscountNode()
    {
        AddField("automaticDiscountNode");
        return this;
    }

    public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}