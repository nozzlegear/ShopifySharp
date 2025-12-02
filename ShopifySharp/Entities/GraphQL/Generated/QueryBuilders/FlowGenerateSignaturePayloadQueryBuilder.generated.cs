#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FlowGenerateSignaturePayloadQueryBuilder() : GraphQueryBuilder<FlowGenerateSignaturePayload>("flowGenerateSignaturePayload")
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

    public FlowGenerateSignaturePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}