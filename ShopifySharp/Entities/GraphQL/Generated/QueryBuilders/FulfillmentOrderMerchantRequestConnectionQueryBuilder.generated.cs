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

public class FulfillmentOrderMerchantRequestConnectionQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMerchantRequestConnection>("fulfillmentOrderMerchantRequestConnection")
{
    public FulfillmentOrderMerchantRequestConnectionQueryBuilder AddFieldEdges(Func<FulfillmentOrderMerchantRequestEdgeQueryBuilder, FulfillmentOrderMerchantRequestEdgeQueryBuilder> build)
    {
        AddField<FulfillmentOrderMerchantRequestEdge, FulfillmentOrderMerchantRequestEdgeQueryBuilder>("edges", build);
        return this;
    }

    public FulfillmentOrderMerchantRequestConnectionQueryBuilder AddFieldNodes(Func<FulfillmentOrderMerchantRequestQueryBuilder, FulfillmentOrderMerchantRequestQueryBuilder> build)
    {
        AddField<FulfillmentOrderMerchantRequest, FulfillmentOrderMerchantRequestQueryBuilder>("nodes", build);
        return this;
    }

    public FulfillmentOrderMerchantRequestConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}