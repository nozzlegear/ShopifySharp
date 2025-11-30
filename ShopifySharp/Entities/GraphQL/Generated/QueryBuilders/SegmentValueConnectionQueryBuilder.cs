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

public class SegmentValueConnectionQueryBuilder() : GraphQueryBuilder<SegmentValueConnection>("query segmentValueConnection")
{
    public SegmentValueConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SegmentValueConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SegmentValueConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}