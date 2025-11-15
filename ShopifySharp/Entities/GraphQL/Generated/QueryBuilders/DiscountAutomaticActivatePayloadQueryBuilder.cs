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

public class DiscountAutomaticActivatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticActivatePayload>("query discountAutomaticActivatePayload")
{
    public DiscountAutomaticActivatePayloadQueryBuilder AddFieldAutomaticDiscountNode()
    {
        AddField("automaticDiscountNode");
        return this;
    }

    public DiscountAutomaticActivatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}