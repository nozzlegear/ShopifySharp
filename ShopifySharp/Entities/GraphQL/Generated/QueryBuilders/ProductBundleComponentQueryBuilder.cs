#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductBundleComponentQueryBuilder() : GraphQueryBuilder<ProductBundleComponent>("query productBundleComponent")
{
    public ProductBundleComponentQueryBuilder AddFieldComponentProduct()
    {
        AddField("componentProduct");
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldComponentVariants()
    {
        AddField("componentVariants");
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldComponentVariantsCount()
    {
        AddField("componentVariantsCount");
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldOptionSelections()
    {
        AddField("optionSelections");
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ProductBundleComponentQueryBuilder AddFieldQuantityOption()
    {
        AddField("quantityOption");
        return this;
    }
}