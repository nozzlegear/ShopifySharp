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

public class DiscountCodeFreeShippingCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShippingCreatePayload>("query discountCodeFreeShippingCreatePayload")
{
    public DiscountCodeFreeShippingCreatePayloadQueryBuilder AddFieldCodeDiscountNode()
    {
        AddField("codeDiscountNode");
        return this;
    }

    public DiscountCodeFreeShippingCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}