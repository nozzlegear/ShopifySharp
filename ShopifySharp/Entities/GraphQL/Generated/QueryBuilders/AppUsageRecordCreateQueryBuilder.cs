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

public class AppUsageRecordCreateQueryBuilder() : GraphQueryBuilder<AppUsageRecordCreatePayload>("query appUsageRecordCreate")
{
    public AppUsageRecordCreateQueryBuilder AddArgumentDescription(string? description)
    {
        AddArgument("description", description);
        return this;
    }

    public AppUsageRecordCreateQueryBuilder AddArgumentIdempotencyKey(string? idempotencyKey)
    {
        AddArgument("idempotencyKey", idempotencyKey);
        return this;
    }

    public AppUsageRecordCreateQueryBuilder AddArgumentPrice(MoneyInput? price)
    {
        AddArgument("price", price);
        return this;
    }

    public AppUsageRecordCreateQueryBuilder AddArgumentSubscriptionLineItemId(string? subscriptionLineItemId)
    {
        AddArgument("subscriptionLineItemId", subscriptionLineItemId);
        return this;
    }
}