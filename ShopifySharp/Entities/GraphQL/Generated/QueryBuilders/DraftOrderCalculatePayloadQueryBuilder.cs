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

public class DraftOrderCalculatePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderCalculatePayload>("query draftOrderCalculatePayload")
{
    public DraftOrderCalculatePayloadQueryBuilder AddFieldCalculatedDraftOrder()
    {
        AddField("calculatedDraftOrder");
        return this;
    }

    public DraftOrderCalculatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}