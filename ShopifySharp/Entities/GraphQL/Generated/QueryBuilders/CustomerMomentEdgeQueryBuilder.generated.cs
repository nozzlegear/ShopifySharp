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

public class CustomerMomentEdgeQueryBuilder() : GraphQueryBuilder<CustomerMomentEdge>("customerMomentEdge")
{
    public CustomerMomentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CustomerMomentEdgeQueryBuilder AddFieldNode(Func<CustomerMomentQueryBuilder, CustomerMomentQueryBuilder> build)
    {
        AddField<ICustomerMoment, CustomerMomentQueryBuilder>("node", build);
        return this;
    }
}