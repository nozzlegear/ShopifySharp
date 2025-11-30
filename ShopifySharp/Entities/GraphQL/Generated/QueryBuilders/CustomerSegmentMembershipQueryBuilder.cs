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

public class CustomerSegmentMembershipQueryBuilder() : GraphQueryBuilder<SegmentMembershipResponse>("query customerSegmentMembership")
{
    public CustomerSegmentMembershipQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerSegmentMembershipQueryBuilder AddArgumentSegmentIds(ICollection<string>? segmentIds)
    {
        AddArgument("segmentIds", segmentIds);
        return this;
    }
}