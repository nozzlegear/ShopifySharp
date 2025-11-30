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

public class CashTrackingSessionQueryBuilder() : GraphQueryBuilder<CashTrackingSession>("query cashTrackingSession")
{
    public CashTrackingSessionQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}