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

public class ProductDuplicateOperationQueryBuilder() : GraphQueryBuilder<ProductDuplicateOperation>("productDuplicateOperation")
{
    public ProductDuplicateOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldNewProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("newProduct", build);
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ProductDuplicateOperationQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}