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

public class ReturnLineItemTypeEdgeQueryBuilder() : GraphQueryBuilder<ReturnLineItemTypeEdge>("returnLineItemTypeEdge")
{
    public ReturnLineItemTypeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReturnLineItemTypeEdgeQueryBuilder AddFieldNode(Func<ReturnLineItemTypeQueryBuilder, ReturnLineItemTypeQueryBuilder> build)
    {
        AddField<IReturnLineItemType, ReturnLineItemTypeQueryBuilder>("node", build);
        return this;
    }
}