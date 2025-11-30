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

public class QuantityRulesAddPayloadQueryBuilder() : GraphQueryBuilder<QuantityRulesAddPayload>("query quantityRulesAddPayload")
{
    public QuantityRulesAddPayloadQueryBuilder AddFieldQuantityRules()
    {
        AddField("quantityRules");
        return this;
    }

    public QuantityRulesAddPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}