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

public class ProductBundleComponentQueryBuilder() : GraphQueryBuilder<ProductBundleComponent>("productBundleComponent")
{
    public ProductBundleComponentQueryBuilder AddFieldComponentProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("componentProduct", build);
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldComponentVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("componentVariants", build);
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldComponentVariantsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("componentVariantsCount", build);
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldOptionSelections(Func<ProductBundleComponentOptionSelectionQueryBuilder, ProductBundleComponentOptionSelectionQueryBuilder> build)
    {
        AddField<ProductBundleComponentOptionSelection, ProductBundleComponentOptionSelectionQueryBuilder>("optionSelections", build);
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldQuantityOption(Func<ProductBundleComponentQuantityOptionQueryBuilder, ProductBundleComponentQuantityOptionQueryBuilder> build)
    {
        AddField<ProductBundleComponentQuantityOption, ProductBundleComponentQuantityOptionQueryBuilder>("quantityOption", build);
        return this;
    }
}