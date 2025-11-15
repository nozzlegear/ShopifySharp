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

public class FlowTriggerReceiveQueryBuilder() : GraphQueryBuilder<FlowTriggerReceivePayload>("query flowTriggerReceive")
{
    public FlowTriggerReceiveQueryBuilder AddArgumentHandle(string? handle)
    {
        AddArgument("handle", handle);
        return this;
    }

    public FlowTriggerReceiveQueryBuilder AddArgumentPayload(string? payload)
    {
        AddArgument("payload", payload);
        return this;
    }
}