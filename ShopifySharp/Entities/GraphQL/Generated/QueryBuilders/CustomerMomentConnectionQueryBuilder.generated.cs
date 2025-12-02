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

public class CustomerMomentConnectionQueryBuilder() : GraphQueryBuilder<CustomerMomentConnection>("customerMomentConnection")
{
    public CustomerMomentConnectionQueryBuilder AddFieldEdges(Func<CustomerMomentEdgeQueryBuilder, CustomerMomentEdgeQueryBuilder> build)
    {
        AddField<CustomerMomentEdge, CustomerMomentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CustomerMomentConnectionQueryBuilder AddFieldNodes(Func<CustomerMomentQueryBuilder, CustomerMomentQueryBuilder> build)
    {
        AddField<ICustomerMoment, CustomerMomentQueryBuilder>("nodes", build);
        return this;
    }

    public CustomerMomentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}