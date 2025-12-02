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

public class ProductDuplicatePayloadQueryBuilder() : GraphQueryBuilder<ProductDuplicatePayload>("productDuplicatePayload")
{
    public ProductDuplicatePayloadQueryBuilder AddFieldImageJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("imageJob", build);
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldNewProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("newProduct", build);
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldProductDuplicateOperation(Func<ProductDuplicateOperationQueryBuilder, ProductDuplicateOperationQueryBuilder> build)
    {
        AddField<ProductDuplicateOperation, ProductDuplicateOperationQueryBuilder>("productDuplicateOperation", build);
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}