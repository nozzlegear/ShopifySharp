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

public class ProductComponentTypeQueryBuilder() : GraphQueryBuilder<ProductComponentType>("query productComponentType")
{
    public ProductComponentTypeQueryBuilder AddFieldComponentVariants()
    {
        AddField("componentVariants");
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldComponentVariantsCount()
    {
        AddField("componentVariantsCount");
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldNonComponentVariants()
    {
        AddField("nonComponentVariants");
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldNonComponentVariantsCount()
    {
        AddField("nonComponentVariantsCount");
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }
}