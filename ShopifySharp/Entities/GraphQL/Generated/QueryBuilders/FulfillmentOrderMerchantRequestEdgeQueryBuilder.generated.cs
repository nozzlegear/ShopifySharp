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

public class FulfillmentOrderMerchantRequestEdgeQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMerchantRequestEdge>("fulfillmentOrderMerchantRequestEdge")
{
    public FulfillmentOrderMerchantRequestEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public FulfillmentOrderMerchantRequestEdgeQueryBuilder AddFieldNode(Func<FulfillmentOrderMerchantRequestQueryBuilder, FulfillmentOrderMerchantRequestQueryBuilder> build)
    {
        AddField<FulfillmentOrderMerchantRequest, FulfillmentOrderMerchantRequestQueryBuilder>("node", build);
        return this;
    }
}