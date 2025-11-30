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

public class CustomerConnectionQueryBuilder() : GraphQueryBuilder<CustomerConnection>("customerConnection")
{
    public CustomerConnectionQueryBuilder AddFieldEdges(Func<CustomerEdgeQueryBuilder, CustomerEdgeQueryBuilder> build)
    {
        AddField<CustomerEdge, CustomerEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CustomerConnectionQueryBuilder AddFieldNodes(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("nodes", build);
        return this;
    }

    public CustomerConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}