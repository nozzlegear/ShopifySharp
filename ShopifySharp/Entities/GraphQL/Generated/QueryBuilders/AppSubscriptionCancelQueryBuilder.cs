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

public class AppSubscriptionCancelQueryBuilder() : GraphQueryBuilder<AppSubscriptionCancelPayload>("query appSubscriptionCancel")
{
    public AppSubscriptionCancelQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public AppSubscriptionCancelQueryBuilder AddArgumentProrate(bool? prorate)
    {
        AddArgument("prorate", prorate);
        return this;
    }
}