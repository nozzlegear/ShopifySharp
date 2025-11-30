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

public class ReturnApproveRequestPayloadQueryBuilder() : GraphQueryBuilder<ReturnApproveRequestPayload>("query returnApproveRequestPayload")
{
    public ReturnApproveRequestPayloadQueryBuilder AddFieldReturn()
    {
        AddField("return");
        return this;
    }

    public ReturnApproveRequestPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}