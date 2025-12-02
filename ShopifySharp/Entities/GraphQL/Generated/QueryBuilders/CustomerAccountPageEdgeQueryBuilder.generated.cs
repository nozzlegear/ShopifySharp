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

public class CustomerAccountPageEdgeQueryBuilder() : GraphQueryBuilder<CustomerAccountPageEdge>("customerAccountPageEdge")
{
    public CustomerAccountPageEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CustomerAccountPageEdgeQueryBuilder AddFieldNode(Func<CustomerAccountPageQueryBuilder, CustomerAccountPageQueryBuilder> build)
    {
        AddField<ICustomerAccountPage, CustomerAccountPageQueryBuilder>("node", build);
        return this;
    }
}