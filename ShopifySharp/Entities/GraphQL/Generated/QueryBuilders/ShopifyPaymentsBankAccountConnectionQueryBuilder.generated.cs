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

public class ShopifyPaymentsBankAccountConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBankAccountConnection>("shopifyPaymentsBankAccountConnection")
{
    public ShopifyPaymentsBankAccountConnectionQueryBuilder AddFieldEdges(Func<ShopifyPaymentsBankAccountEdgeQueryBuilder, ShopifyPaymentsBankAccountEdgeQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBankAccountEdge, ShopifyPaymentsBankAccountEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ShopifyPaymentsBankAccountConnectionQueryBuilder AddFieldNodes(Func<ShopifyPaymentsBankAccountQueryBuilder, ShopifyPaymentsBankAccountQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBankAccount, ShopifyPaymentsBankAccountQueryBuilder>("nodes", build);
        return this;
    }

    public ShopifyPaymentsBankAccountConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}