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

public class ReturnReopenPayloadQueryBuilder() : GraphQueryBuilder<ReturnReopenPayload>("query returnReopenPayload")
{
    public ReturnReopenPayloadQueryBuilder AddFieldReturn()
    {
        AddField("return");
        return this;
    }

    public ReturnReopenPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}