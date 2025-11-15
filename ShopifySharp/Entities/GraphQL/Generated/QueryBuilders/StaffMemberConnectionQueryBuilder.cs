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

public class StaffMemberConnectionQueryBuilder() : GraphQueryBuilder<StaffMemberConnection>("query staffMemberConnection")
{
    public StaffMemberConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public StaffMemberConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StaffMemberConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}