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

public class ProductBundleComponentOptionSelectionQueryBuilder() : GraphQueryBuilder<ProductBundleComponentOptionSelection>("productBundleComponentOptionSelection")
{
    public ProductBundleComponentOptionSelectionQueryBuilder AddFieldComponentOption(Func<ProductOptionQueryBuilder, ProductOptionQueryBuilder> build)
    {
        AddField<ProductOption, ProductOptionQueryBuilder>("componentOption", build);
        return this;
    }

    public ProductBundleComponentOptionSelectionQueryBuilder AddFieldParentOption(Func<ProductOptionQueryBuilder, ProductOptionQueryBuilder> build)
    {
        AddField<ProductOption, ProductOptionQueryBuilder>("parentOption", build);
        return this;
    }

    public ProductBundleComponentOptionSelectionQueryBuilder AddFieldValues(Func<ProductBundleComponentOptionSelectionValueQueryBuilder, ProductBundleComponentOptionSelectionValueQueryBuilder> build)
    {
        AddField<ProductBundleComponentOptionSelectionValue, ProductBundleComponentOptionSelectionValueQueryBuilder>("values", build);
        return this;
    }
}