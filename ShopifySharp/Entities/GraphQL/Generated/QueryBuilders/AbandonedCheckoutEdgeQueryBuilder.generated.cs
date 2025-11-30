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

public class AbandonedCheckoutEdgeQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutEdge>("abandonedCheckoutEdge")
{
    public AbandonedCheckoutEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AbandonedCheckoutEdgeQueryBuilder AddFieldNode(Func<AbandonedCheckoutQueryBuilder, AbandonedCheckoutQueryBuilder> build)
    {
        AddField<AbandonedCheckout, AbandonedCheckoutQueryBuilder>("node", build);
        return this;
    }
}