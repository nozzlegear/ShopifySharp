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

public class DiscountCodeAppUpdatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeAppUpdatePayload>("query discountCodeAppUpdatePayload")
{
    public DiscountCodeAppUpdatePayloadQueryBuilder AddFieldCodeAppDiscount()
    {
        AddField("codeAppDiscount");
        return this;
    }

    public DiscountCodeAppUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}