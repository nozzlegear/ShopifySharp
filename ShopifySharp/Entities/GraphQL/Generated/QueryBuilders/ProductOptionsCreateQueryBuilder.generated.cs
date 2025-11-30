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

public class ProductOptionsCreateQueryBuilder() : GraphQueryBuilder<ProductOptionsCreatePayload>("productOptionsCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductOptionsCreateQueryBuilder AddArgumentOptions(ICollection<OptionCreateInput>? options)
    {
        AddArgument("options", options);
        return this;
    }

    public ProductOptionsCreateQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductOptionsCreateQueryBuilder AddArgumentVariantStrategy(ProductOptionCreateVariantStrategy? variantStrategy)
    {
        AddArgument("variantStrategy", variantStrategy);
        return this;
    }
}