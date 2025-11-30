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

public class ProductBundleComponentEdgeQueryBuilder() : GraphQueryBuilder<ProductBundleComponentEdge>("productBundleComponentEdge")
{
    public ProductBundleComponentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ProductBundleComponentEdgeQueryBuilder AddFieldNode(Func<ProductBundleComponentQueryBuilder, ProductBundleComponentQueryBuilder> build)
    {
        AddField<ProductBundleComponent, ProductBundleComponentQueryBuilder>("node", build);
        return this;
    }
}