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

public class DraftOrderCreatePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderCreatePayload>("query draftOrderCreatePayload")
{
    public DraftOrderCreatePayloadQueryBuilder AddFieldDraftOrder()
    {
        AddField("draftOrder");
        return this;
    }

    public DraftOrderCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}