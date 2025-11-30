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

public class CustomerVisitProductInfoEdgeQueryBuilder() : GraphQueryBuilder<CustomerVisitProductInfoEdge>("customerVisitProductInfoEdge")
{
    public CustomerVisitProductInfoEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CustomerVisitProductInfoEdgeQueryBuilder AddFieldNode(Func<CustomerVisitProductInfoQueryBuilder, CustomerVisitProductInfoQueryBuilder> build)
    {
        AddField<CustomerVisitProductInfo, CustomerVisitProductInfoQueryBuilder>("node", build);
        return this;
    }
}