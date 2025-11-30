#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopPolicyUpdatePayloadQueryBuilder() : GraphQueryBuilder<ShopPolicyUpdatePayload>("shopPolicyUpdatePayload")
{
    public ShopPolicyUpdatePayloadQueryBuilder AddFieldShopPolicy(Func<ShopPolicyQueryBuilder, ShopPolicyQueryBuilder> build)
    {
        AddField<ShopPolicy, ShopPolicyQueryBuilder>("shopPolicy", build);
        return this;
    }

    public ShopPolicyUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ShopPolicyUserErrorQueryBuilder, ShopPolicyUserErrorQueryBuilder> build)
    {
        AddField<ShopPolicyUserError, ShopPolicyUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}