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

public class ProductUpdateQueryBuilder() : GraphQueryBuilder<ProductUpdatePayload>("productUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductUpdateQueryBuilder AddArgumentMedia(ICollection<CreateMediaInput>? media)
    {
        AddArgument("media", media);
        return this;
    }

    public ProductUpdateQueryBuilder AddArgumentProduct(ProductUpdateInput? product)
    {
        AddArgument("product", product);
        return this;
    }
}