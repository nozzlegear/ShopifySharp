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

public class ScriptTagCreatePayloadQueryBuilder() : GraphQueryBuilder<ScriptTagCreatePayload>("query scriptTagCreatePayload")
{
    public ScriptTagCreatePayloadQueryBuilder AddFieldScriptTag()
    {
        AddField("scriptTag");
        return this;
    }

    public ScriptTagCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}