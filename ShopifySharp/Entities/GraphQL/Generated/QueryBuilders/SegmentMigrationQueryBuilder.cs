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

public class SegmentMigrationQueryBuilder() : GraphQueryBuilder<SegmentMigration>("query segmentMigration")
{
    public SegmentMigrationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SegmentMigrationQueryBuilder AddFieldSavedSearchId()
    {
        AddField("savedSearchId");
        return this;
    }

    public SegmentMigrationQueryBuilder AddFieldSegmentId()
    {
        AddField("segmentId");
        return this;
    }
}