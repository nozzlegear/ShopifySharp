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

public class CustomerSegmentMemberConnectionQueryBuilder() : GraphQueryBuilder<CustomerSegmentMemberConnection>("query customerSegmentMemberConnection")
{
    public CustomerSegmentMemberConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CustomerSegmentMemberConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }

    public CustomerSegmentMemberConnectionQueryBuilder AddFieldStatistics()
    {
        AddField("statistics");
        return this;
    }

    public CustomerSegmentMemberConnectionQueryBuilder AddFieldTotalCount()
    {
        AddField("totalCount");
        return this;
    }
}