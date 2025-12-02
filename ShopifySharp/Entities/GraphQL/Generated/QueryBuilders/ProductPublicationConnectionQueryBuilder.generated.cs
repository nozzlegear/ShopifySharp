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

public class ProductPublicationConnectionQueryBuilder() : GraphQueryBuilder<ProductPublicationConnection>("productPublicationConnection")
{
    public ProductPublicationConnectionQueryBuilder AddFieldEdges(Func<ProductPublicationEdgeQueryBuilder, ProductPublicationEdgeQueryBuilder> build)
    {
        AddField<ProductPublicationEdge, ProductPublicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductPublicationConnectionQueryBuilder AddFieldNodes(Func<ProductPublicationQueryBuilder, ProductPublicationQueryBuilder> build)
    {
        AddField<ProductPublication, ProductPublicationQueryBuilder>("nodes", build);
        return this;
    }

    public ProductPublicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}