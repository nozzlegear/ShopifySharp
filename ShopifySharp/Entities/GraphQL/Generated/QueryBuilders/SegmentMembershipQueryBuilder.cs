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

public class SegmentMembershipQueryBuilder() : GraphQueryBuilder<SegmentMembership>("query segmentMembership")
{
    public SegmentMembershipQueryBuilder AddFieldIsMember()
    {
        AddField("isMember");
        return this;
    }

    public SegmentMembershipQueryBuilder AddFieldSegmentId()
    {
        AddField("segmentId");
        return this;
    }
}