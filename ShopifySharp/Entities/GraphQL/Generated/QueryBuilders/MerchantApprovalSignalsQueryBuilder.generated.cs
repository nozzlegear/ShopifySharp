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

public class MerchantApprovalSignalsQueryBuilder() : GraphQueryBuilder<MerchantApprovalSignals>("merchantApprovalSignals")
{
    public MerchantApprovalSignalsQueryBuilder AddFieldIdentityVerified()
    {
        AddField("identityVerified");
        return this;
    }

    public MerchantApprovalSignalsQueryBuilder AddFieldVerifiedByShopify()
    {
        AddField("verifiedByShopify");
        return this;
    }

    public MerchantApprovalSignalsQueryBuilder AddFieldVerifiedByShopifyTier()
    {
        AddField("verifiedByShopifyTier");
        return this;
    }
}