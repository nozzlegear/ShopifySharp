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

public class DiscountAutomaticBasicUpdatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBasicUpdatePayload>("query discountAutomaticBasicUpdatePayload")
{
    public DiscountAutomaticBasicUpdatePayloadQueryBuilder AddFieldAutomaticDiscountNode()
    {
        AddField("automaticDiscountNode");
        return this;
    }

    public DiscountAutomaticBasicUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}