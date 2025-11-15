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

public class ProductDeleteOperationQueryBuilder() : GraphQueryBuilder<ProductDeleteOperation>("query productDeleteOperation")
{
    public ProductDeleteOperationQueryBuilder AddFieldDeletedProductId()
    {
        AddField("deletedProductId");
        return this;
    }

    public ProductDeleteOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductDeleteOperationQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductDeleteOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ProductDeleteOperationQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}