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

public class FlowGenerateSignatureQueryBuilder() : GraphQueryBuilder<FlowGenerateSignaturePayload>("query flowGenerateSignature")
{
    public FlowGenerateSignatureQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FlowGenerateSignatureQueryBuilder AddArgumentPayload(string? payload)
    {
        AddArgument("payload", payload);
        return this;
    }
}