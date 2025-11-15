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

public class DraftOrderDuplicatePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderDuplicatePayload>("query draftOrderDuplicatePayload")
{
    public DraftOrderDuplicatePayloadQueryBuilder AddFieldDraftOrder()
    {
        AddField("draftOrder");
        return this;
    }

    public DraftOrderDuplicatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}