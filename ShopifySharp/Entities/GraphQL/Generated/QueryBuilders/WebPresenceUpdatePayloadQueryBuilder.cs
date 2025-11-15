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

public class WebPresenceUpdatePayloadQueryBuilder() : GraphQueryBuilder<WebPresenceUpdatePayload>("query webPresenceUpdatePayload")
{
    public WebPresenceUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public WebPresenceUpdatePayloadQueryBuilder AddFieldWebPresence()
    {
        AddField("webPresence");
        return this;
    }
}