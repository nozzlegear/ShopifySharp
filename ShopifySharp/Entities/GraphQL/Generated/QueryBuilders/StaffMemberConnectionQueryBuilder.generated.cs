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

public class StaffMemberConnectionQueryBuilder() : GraphQueryBuilder<StaffMemberConnection>("staffMemberConnection")
{
    public StaffMemberConnectionQueryBuilder AddFieldEdges(Func<StaffMemberEdgeQueryBuilder, StaffMemberEdgeQueryBuilder> build)
    {
        AddField<StaffMemberEdge, StaffMemberEdgeQueryBuilder>("edges", build);
        return this;
    }

    public StaffMemberConnectionQueryBuilder AddFieldNodes(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("nodes", build);
        return this;
    }

    public StaffMemberConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}