#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SegmentMigrationEdgeQueryBuilder() : GraphQueryBuilder<SegmentMigrationEdge>("segmentMigrationEdge")
{
    public SegmentMigrationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SegmentMigrationEdgeQueryBuilder AddFieldNode(Func<SegmentMigrationQueryBuilder, SegmentMigrationQueryBuilder> build)
    {
        AddField<SegmentMigration, SegmentMigrationQueryBuilder>("node", build);
        return this;
    }
}