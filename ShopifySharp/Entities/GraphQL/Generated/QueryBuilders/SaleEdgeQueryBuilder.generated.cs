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

public class SaleEdgeQueryBuilder() : GraphQueryBuilder<SaleEdge>("saleEdge")
{
    public SaleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SaleEdgeQueryBuilder AddFieldNode(Func<SaleQueryBuilder, SaleQueryBuilder> build)
    {
        AddField<ISale, SaleQueryBuilder>("node", build);
        return this;
    }
}