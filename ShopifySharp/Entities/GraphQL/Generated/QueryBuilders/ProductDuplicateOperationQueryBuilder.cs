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

public class ProductDuplicateOperationQueryBuilder() : GraphQueryBuilder<ProductDuplicateOperation>("query productDuplicateOperation")
{
    public ProductDuplicateOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldNewProduct()
    {
        AddField("newProduct");
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}