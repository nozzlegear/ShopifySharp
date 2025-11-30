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

public class AbandonedCheckoutLineItemEdgeQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItemEdge>("abandonedCheckoutLineItemEdge")
{
    public AbandonedCheckoutLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AbandonedCheckoutLineItemEdgeQueryBuilder AddFieldNode(Func<AbandonedCheckoutLineItemQueryBuilder, AbandonedCheckoutLineItemQueryBuilder> build)
    {
        AddField<AbandonedCheckoutLineItem, AbandonedCheckoutLineItemQueryBuilder>("node", build);
        return this;
    }
}