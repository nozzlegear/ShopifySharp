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

public class ReturnClosePayloadQueryBuilder() : GraphQueryBuilder<ReturnClosePayload>("query returnClosePayload")
{
    public ReturnClosePayloadQueryBuilder AddFieldReturn()
    {
        AddField("return");
        return this;
    }

    public ReturnClosePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}