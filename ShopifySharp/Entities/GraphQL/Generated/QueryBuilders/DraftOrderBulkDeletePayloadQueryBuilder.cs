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

public class DraftOrderBulkDeletePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderBulkDeletePayload>("query draftOrderBulkDeletePayload")
{
    public DraftOrderBulkDeletePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public DraftOrderBulkDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}