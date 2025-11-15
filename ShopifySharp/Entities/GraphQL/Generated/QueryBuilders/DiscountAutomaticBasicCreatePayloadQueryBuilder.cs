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

public class DiscountAutomaticBasicCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBasicCreatePayload>("query discountAutomaticBasicCreatePayload")
{
    public DiscountAutomaticBasicCreatePayloadQueryBuilder AddFieldAutomaticDiscountNode()
    {
        AddField("automaticDiscountNode");
        return this;
    }

    public DiscountAutomaticBasicCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}