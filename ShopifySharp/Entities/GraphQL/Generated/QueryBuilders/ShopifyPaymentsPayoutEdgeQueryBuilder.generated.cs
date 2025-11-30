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

public class ShopifyPaymentsPayoutEdgeQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutEdge>("shopifyPaymentsPayoutEdge")
{
    public ShopifyPaymentsPayoutEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ShopifyPaymentsPayoutEdgeQueryBuilder AddFieldNode(Func<ShopifyPaymentsPayoutQueryBuilder, ShopifyPaymentsPayoutQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayout, ShopifyPaymentsPayoutQueryBuilder>("node", build);
        return this;
    }
}