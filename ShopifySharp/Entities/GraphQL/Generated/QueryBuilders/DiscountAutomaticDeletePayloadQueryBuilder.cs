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

public class DiscountAutomaticDeletePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticDeletePayload>("query discountAutomaticDeletePayload")
{
    public DiscountAutomaticDeletePayloadQueryBuilder AddFieldDeletedAutomaticDiscountId()
    {
        AddField("deletedAutomaticDiscountId");
        return this;
    }

    public DiscountAutomaticDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}