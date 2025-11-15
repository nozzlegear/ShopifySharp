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

public class ReturnCreatePayloadQueryBuilder() : GraphQueryBuilder<ReturnCreatePayload>("query returnCreatePayload")
{
    public ReturnCreatePayloadQueryBuilder AddFieldReturn()
    {
        AddField("return");
        return this;
    }

    public ReturnCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}