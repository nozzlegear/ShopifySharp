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

public class SegmentCreatePayloadQueryBuilder() : GraphQueryBuilder<SegmentCreatePayload>("segmentCreatePayload")
{
    public SegmentCreatePayloadQueryBuilder AddFieldSegment(Func<SegmentQueryBuilder, SegmentQueryBuilder> build)
    {
        AddField<Segment, SegmentQueryBuilder>("segment", build);
        return this;
    }

    public SegmentCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}