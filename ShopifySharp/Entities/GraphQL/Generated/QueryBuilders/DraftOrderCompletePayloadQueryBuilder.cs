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

public class DraftOrderCompletePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderCompletePayload>("query draftOrderCompletePayload")
{
    public DraftOrderCompletePayloadQueryBuilder AddFieldDraftOrder()
    {
        AddField("draftOrder");
        return this;
    }

    public DraftOrderCompletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}