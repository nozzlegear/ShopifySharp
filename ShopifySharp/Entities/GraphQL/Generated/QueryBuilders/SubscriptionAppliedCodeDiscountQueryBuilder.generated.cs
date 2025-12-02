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

public class SubscriptionAppliedCodeDiscountQueryBuilder() : GraphQueryBuilder<SubscriptionAppliedCodeDiscount>("subscriptionAppliedCodeDiscount")
{
    public SubscriptionAppliedCodeDiscountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionAppliedCodeDiscountQueryBuilder AddFieldRedeemCode()
    {
        AddField("redeemCode");
        return this;
    }

    public SubscriptionAppliedCodeDiscountQueryBuilder AddFieldRejectionReason()
    {
        AddField("rejectionReason");
        return this;
    }
}