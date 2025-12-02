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

public class CustomerSegmentMemberEdgeQueryBuilder() : GraphQueryBuilder<CustomerSegmentMemberEdge>("customerSegmentMemberEdge")
{
    public CustomerSegmentMemberEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CustomerSegmentMemberEdgeQueryBuilder AddFieldNode(Func<CustomerSegmentMemberQueryBuilder, CustomerSegmentMemberQueryBuilder> build)
    {
        AddField<CustomerSegmentMember, CustomerSegmentMemberQueryBuilder>("node", build);
        return this;
    }
}