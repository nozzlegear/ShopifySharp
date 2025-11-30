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

public class SegmentDeletePayloadQueryBuilder() : GraphQueryBuilder<SegmentDeletePayload>("query segmentDeletePayload")
{
    public SegmentDeletePayloadQueryBuilder AddFieldDeletedSegmentId()
    {
        AddField("deletedSegmentId");
        return this;
    }

    public SegmentDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}