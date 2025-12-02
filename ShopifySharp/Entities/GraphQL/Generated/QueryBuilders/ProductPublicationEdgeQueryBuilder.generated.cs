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

public class ProductPublicationEdgeQueryBuilder() : GraphQueryBuilder<ProductPublicationEdge>("productPublicationEdge")
{
    public ProductPublicationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ProductPublicationEdgeQueryBuilder AddFieldNode(Func<ProductPublicationQueryBuilder, ProductPublicationQueryBuilder> build)
    {
        AddField<ProductPublication, ProductPublicationQueryBuilder>("node", build);
        return this;
    }
}