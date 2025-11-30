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

public class StandardizedProductTypeQueryBuilder() : GraphQueryBuilder<StandardizedProductType>("standardizedProductType")
{
    public StandardizedProductTypeQueryBuilder AddFieldProductTaxonomyNode(Func<ProductTaxonomyNodeQueryBuilder, ProductTaxonomyNodeQueryBuilder> build)
    {
        AddField<ProductTaxonomyNode, ProductTaxonomyNodeQueryBuilder>("productTaxonomyNode", build);
        return this;
    }
}