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

public class DraftOrderCreateFromOrderPayloadQueryBuilder() : GraphQueryBuilder<DraftOrderCreateFromOrderPayload>("query draftOrderCreateFromOrderPayload")
{
    public DraftOrderCreateFromOrderPayloadQueryBuilder AddFieldDraftOrder()
    {
        AddField("draftOrder");
        return this;
    }

    public DraftOrderCreateFromOrderPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}