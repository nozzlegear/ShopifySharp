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

public class DiscountCodeBasicUpdatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeBasicUpdatePayload>("query discountCodeBasicUpdatePayload")
{
    public DiscountCodeBasicUpdatePayloadQueryBuilder AddFieldCodeDiscountNode()
    {
        AddField("codeDiscountNode");
        return this;
    }

    public DiscountCodeBasicUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}