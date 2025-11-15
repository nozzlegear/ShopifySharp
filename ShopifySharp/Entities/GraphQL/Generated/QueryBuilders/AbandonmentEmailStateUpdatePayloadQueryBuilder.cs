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

public class AbandonmentEmailStateUpdatePayloadQueryBuilder() : GraphQueryBuilder<AbandonmentEmailStateUpdatePayload>("query abandonmentEmailStateUpdatePayload")
{
    public AbandonmentEmailStateUpdatePayloadQueryBuilder AddFieldAbandonment()
    {
        AddField("abandonment");
        return this;
    }

    public AbandonmentEmailStateUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}