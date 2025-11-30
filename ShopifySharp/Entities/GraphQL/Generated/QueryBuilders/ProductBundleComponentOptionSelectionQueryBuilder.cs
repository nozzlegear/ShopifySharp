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

public class ProductBundleComponentOptionSelectionQueryBuilder() : GraphQueryBuilder<ProductBundleComponentOptionSelection>("query productBundleComponentOptionSelection")
{
    public ProductBundleComponentOptionSelectionQueryBuilder AddFieldComponentOption()
    {
        AddField("componentOption");
        return this;
    }

    public ProductBundleComponentOptionSelectionQueryBuilder AddFieldParentOption()
    {
        AddField("parentOption");
        return this;
    }

    public ProductBundleComponentOptionSelectionQueryBuilder AddFieldValues()
    {
        AddField("values");
        return this;
    }
}