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

public class WebPresenceCreatePayloadQueryBuilder() : GraphQueryBuilder<WebPresenceCreatePayload>("query webPresenceCreatePayload")
{
    public WebPresenceCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public WebPresenceCreatePayloadQueryBuilder AddFieldWebPresence()
    {
        AddField("webPresence");
        return this;
    }
}