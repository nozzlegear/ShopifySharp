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

public class ProductDuplicateQueryBuilder() : GraphQueryBuilder<ProductDuplicatePayload>("productDuplicate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductDuplicateQueryBuilder AddArgumentIncludeImages(bool? includeImages)
    {
        AddArgument("includeImages", includeImages);
        return this;
    }

    public ProductDuplicateQueryBuilder AddArgumentIncludeTranslations(bool? includeTranslations)
    {
        AddArgument("includeTranslations", includeTranslations);
        return this;
    }

    public ProductDuplicateQueryBuilder AddArgumentNewStatus(ProductStatus? newStatus)
    {
        AddArgument("newStatus", newStatus);
        return this;
    }

    public ProductDuplicateQueryBuilder AddArgumentNewTitle(string? newTitle)
    {
        AddArgument("newTitle", newTitle);
        return this;
    }

    public ProductDuplicateQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductDuplicateQueryBuilder AddArgumentSynchronous(bool? synchronous)
    {
        AddArgument("synchronous", synchronous);
        return this;
    }
}