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

public class ProductBundleComponentOptionSelectionValueQueryBuilder() : GraphQueryBuilder<ProductBundleComponentOptionSelectionValue>("productBundleComponentOptionSelectionValue")
{
    public ProductBundleComponentOptionSelectionValueQueryBuilder AddFieldSelectionStatus()
    {
        AddField("selectionStatus");
        return this;
    }

    public ProductBundleComponentOptionSelectionValueQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}