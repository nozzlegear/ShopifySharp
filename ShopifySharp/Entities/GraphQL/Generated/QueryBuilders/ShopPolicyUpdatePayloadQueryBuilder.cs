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

public class ShopPolicyUpdatePayloadQueryBuilder() : GraphQueryBuilder<ShopPolicyUpdatePayload>("query shopPolicyUpdatePayload")
{
    public ShopPolicyUpdatePayloadQueryBuilder AddFieldShopPolicy()
    {
        AddField("shopPolicy");
        return this;
    }

    public ShopPolicyUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}