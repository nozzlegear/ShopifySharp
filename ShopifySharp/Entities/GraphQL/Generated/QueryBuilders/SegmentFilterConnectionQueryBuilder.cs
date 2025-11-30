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

public class SegmentFilterConnectionQueryBuilder() : GraphQueryBuilder<SegmentFilterConnection>("query segmentFilterConnection")
{
    public SegmentFilterConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SegmentFilterConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SegmentFilterConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}