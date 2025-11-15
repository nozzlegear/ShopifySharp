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

public class DiscountCodeFreeShippingUpdatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShippingUpdatePayload>("query discountCodeFreeShippingUpdatePayload")
{
    public DiscountCodeFreeShippingUpdatePayloadQueryBuilder AddFieldCodeDiscountNode()
    {
        AddField("codeDiscountNode");
        return this;
    }

    public DiscountCodeFreeShippingUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}