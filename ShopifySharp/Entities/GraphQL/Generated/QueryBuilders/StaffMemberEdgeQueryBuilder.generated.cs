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

public class StaffMemberEdgeQueryBuilder() : GraphQueryBuilder<StaffMemberEdge>("staffMemberEdge")
{
    public StaffMemberEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public StaffMemberEdgeQueryBuilder AddFieldNode(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("node", build);
        return this;
    }
}