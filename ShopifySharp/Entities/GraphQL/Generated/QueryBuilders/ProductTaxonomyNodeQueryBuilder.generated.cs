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

public class ProductTaxonomyNodeQueryBuilder() : GraphQueryBuilder<ProductTaxonomyNode>("productTaxonomyNode")
{
    public ProductTaxonomyNodeQueryBuilder AddFieldFullName()
    {
        AddField("fullName");
        return this;
    }

    public ProductTaxonomyNodeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductTaxonomyNodeQueryBuilder AddFieldIsLeaf()
    {
        AddField("isLeaf");
        return this;
    }

    public ProductTaxonomyNodeQueryBuilder AddFieldIsRoot()
    {
        AddField("isRoot");
        return this;
    }

    public ProductTaxonomyNodeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}