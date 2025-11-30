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

public class SegmentUpdatePayloadQueryBuilder() : GraphQueryBuilder<SegmentUpdatePayload>("query segmentUpdatePayload")
{
    public SegmentUpdatePayloadQueryBuilder AddFieldSegment()
    {
        AddField("segment");
        return this;
    }

    public SegmentUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}