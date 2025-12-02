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

public class AppDiscountTypeEdgeQueryBuilder() : GraphQueryBuilder<AppDiscountTypeEdge>("appDiscountTypeEdge")
{
    public AppDiscountTypeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AppDiscountTypeEdgeQueryBuilder AddFieldNode(Func<AppDiscountTypeQueryBuilder, AppDiscountTypeQueryBuilder> build)
    {
        AddField<AppDiscountType, AppDiscountTypeQueryBuilder>("node", build);
        return this;
    }
}