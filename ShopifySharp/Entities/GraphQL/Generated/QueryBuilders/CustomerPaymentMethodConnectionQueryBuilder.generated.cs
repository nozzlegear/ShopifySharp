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

public class CustomerPaymentMethodConnectionQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodConnection>("customerPaymentMethodConnection")
{
    public CustomerPaymentMethodConnectionQueryBuilder AddFieldEdges(Func<CustomerPaymentMethodEdgeQueryBuilder, CustomerPaymentMethodEdgeQueryBuilder> build)
    {
        AddField<CustomerPaymentMethodEdge, CustomerPaymentMethodEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CustomerPaymentMethodConnectionQueryBuilder AddFieldNodes(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("nodes", build);
        return this;
    }

    public CustomerPaymentMethodConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}