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

public class ProductBundleComponentQuantityOptionQueryBuilder() : GraphQueryBuilder<ProductBundleComponentQuantityOption>("productBundleComponentQuantityOption")
{
    public ProductBundleComponentQuantityOptionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ProductBundleComponentQuantityOptionQueryBuilder AddFieldParentOption(Func<ProductOptionQueryBuilder, ProductOptionQueryBuilder> build)
    {
        AddField<ProductOption, ProductOptionQueryBuilder>("parentOption", build);
        return this;
    }

    public ProductBundleComponentQuantityOptionQueryBuilder AddFieldValues(Func<ProductBundleComponentQuantityOptionValueQueryBuilder, ProductBundleComponentQuantityOptionValueQueryBuilder> build)
    {
        AddField<ProductBundleComponentQuantityOptionValue, ProductBundleComponentQuantityOptionValueQueryBuilder>("values", build);
        return this;
    }
}