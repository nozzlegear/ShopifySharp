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

public class ShopifyProtectOrderSummaryQueryBuilder() : GraphQueryBuilder<ShopifyProtectOrderSummary>("shopifyProtectOrderSummary")
{
    public ShopifyProtectOrderSummaryQueryBuilder AddFieldEligibility(Func<ShopifyProtectOrderEligibilityQueryBuilder, ShopifyProtectOrderEligibilityQueryBuilder> build)
    {
        AddField<ShopifyProtectOrderEligibility, ShopifyProtectOrderEligibilityQueryBuilder>("eligibility", build);
        return this;
    }

    public ShopifyProtectOrderSummaryQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}