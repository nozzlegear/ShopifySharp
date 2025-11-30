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

public class CustomerAccountPageConnectionQueryBuilder() : GraphQueryBuilder<CustomerAccountPageConnection>("customerAccountPageConnection")
{
    public CustomerAccountPageConnectionQueryBuilder AddFieldEdges(Func<CustomerAccountPageEdgeQueryBuilder, CustomerAccountPageEdgeQueryBuilder> build)
    {
        AddField<CustomerAccountPageEdge, CustomerAccountPageEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CustomerAccountPageConnectionQueryBuilder AddFieldNodes(Func<CustomerAccountPageQueryBuilder, CustomerAccountPageQueryBuilder> build)
    {
        AddField<ICustomerAccountPage, CustomerAccountPageQueryBuilder>("nodes", build);
        return this;
    }

    public CustomerAccountPageConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}