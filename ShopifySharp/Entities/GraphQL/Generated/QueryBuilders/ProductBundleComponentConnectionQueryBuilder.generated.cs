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

public class ProductBundleComponentConnectionQueryBuilder() : GraphQueryBuilder<ProductBundleComponentConnection>("productBundleComponentConnection")
{
    public ProductBundleComponentConnectionQueryBuilder AddFieldEdges(Func<ProductBundleComponentEdgeQueryBuilder, ProductBundleComponentEdgeQueryBuilder> build)
    {
        AddField<ProductBundleComponentEdge, ProductBundleComponentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductBundleComponentConnectionQueryBuilder AddFieldNodes(Func<ProductBundleComponentQueryBuilder, ProductBundleComponentQueryBuilder> build)
    {
        AddField<ProductBundleComponent, ProductBundleComponentQueryBuilder>("nodes", build);
        return this;
    }

    public ProductBundleComponentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}