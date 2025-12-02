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

public class DraftOrderLineItemEdgeQueryBuilder() : GraphQueryBuilder<DraftOrderLineItemEdge>("draftOrderLineItemEdge")
{
    public DraftOrderLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DraftOrderLineItemEdgeQueryBuilder AddFieldNode(Func<DraftOrderLineItemQueryBuilder, DraftOrderLineItemQueryBuilder> build)
    {
        AddField<DraftOrderLineItem, DraftOrderLineItemQueryBuilder>("node", build);
        return this;
    }
}