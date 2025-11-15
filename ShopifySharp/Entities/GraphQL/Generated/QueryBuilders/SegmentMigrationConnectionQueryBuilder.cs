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

public class SegmentMigrationConnectionQueryBuilder() : GraphQueryBuilder<SegmentMigrationConnection>("query segmentMigrationConnection")
{
    public SegmentMigrationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SegmentMigrationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SegmentMigrationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}