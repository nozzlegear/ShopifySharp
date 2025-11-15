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

public class DiscountCodeAppCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeAppCreatePayload>("query discountCodeAppCreatePayload")
{
    public DiscountCodeAppCreatePayloadQueryBuilder AddFieldCodeAppDiscount()
    {
        AddField("codeAppDiscount");
        return this;
    }

    public DiscountCodeAppCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}