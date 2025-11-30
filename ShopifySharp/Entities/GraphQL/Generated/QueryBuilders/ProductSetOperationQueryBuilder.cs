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

public class ProductSetOperationQueryBuilder() : GraphQueryBuilder<ProductSetOperation>("query productSetOperation")
{
    public ProductSetOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductSetOperationQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductSetOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ProductSetOperationQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}