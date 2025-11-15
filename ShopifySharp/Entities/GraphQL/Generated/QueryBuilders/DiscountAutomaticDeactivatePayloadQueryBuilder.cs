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

public class DiscountAutomaticDeactivatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticDeactivatePayload>("query discountAutomaticDeactivatePayload")
{
    public DiscountAutomaticDeactivatePayloadQueryBuilder AddFieldAutomaticDiscountNode()
    {
        AddField("automaticDiscountNode");
        return this;
    }

    public DiscountAutomaticDeactivatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}