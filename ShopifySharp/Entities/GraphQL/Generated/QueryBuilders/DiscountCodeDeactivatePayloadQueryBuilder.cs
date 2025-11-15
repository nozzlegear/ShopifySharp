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

public class DiscountCodeDeactivatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeDeactivatePayload>("query discountCodeDeactivatePayload")
{
    public DiscountCodeDeactivatePayloadQueryBuilder AddFieldCodeDiscountNode()
    {
        AddField("codeDiscountNode");
        return this;
    }

    public DiscountCodeDeactivatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}