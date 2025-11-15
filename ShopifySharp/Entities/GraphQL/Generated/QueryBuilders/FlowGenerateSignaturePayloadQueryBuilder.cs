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

public class FlowGenerateSignaturePayloadQueryBuilder() : GraphQueryBuilder<FlowGenerateSignaturePayload>("query flowGenerateSignaturePayload")
{
    public FlowGenerateSignaturePayloadQueryBuilder AddFieldPayload()
    {
        AddField("payload");
        return this;
    }

    public FlowGenerateSignaturePayloadQueryBuilder AddFieldSignature()
    {
        AddField("signature");
        return this;
    }

    public FlowGenerateSignaturePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}