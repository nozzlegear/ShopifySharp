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

public class MarketingActivityUpdateQueryBuilder() : GraphQueryBuilder<MarketingActivityUpdatePayload>("query marketingActivityUpdate")
{
    public MarketingActivityUpdateQueryBuilder AddArgumentInput(MarketingActivityUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}