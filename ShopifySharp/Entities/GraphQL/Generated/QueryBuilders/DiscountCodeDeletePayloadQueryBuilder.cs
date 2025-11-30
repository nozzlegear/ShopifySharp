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

public class DiscountCodeDeletePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeDeletePayload>("query discountCodeDeletePayload")
{
    public DiscountCodeDeletePayloadQueryBuilder AddFieldDeletedCodeDiscountId()
    {
        AddField("deletedCodeDiscountId");
        return this;
    }

    public DiscountCodeDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}