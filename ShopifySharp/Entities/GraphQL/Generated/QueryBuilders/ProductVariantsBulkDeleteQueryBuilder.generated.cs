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

public class ProductVariantsBulkDeleteQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkDeletePayload>("productVariantsBulkDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductVariantsBulkDeleteQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductVariantsBulkDeleteQueryBuilder AddArgumentVariantsIds(ICollection<string>? variantsIds)
    {
        AddArgument("variantsIds", variantsIds);
        return this;
    }
}