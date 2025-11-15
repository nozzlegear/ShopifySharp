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

public class MarketLocalizableResourceQueryBuilder() : GraphQueryBuilder<MarketLocalizableResource>("query marketLocalizableResource")
{
    public MarketLocalizableResourceQueryBuilder AddArgumentResourceId(string? resourceId)
    {
        AddArgument("resourceId", resourceId);
        return this;
    }
}