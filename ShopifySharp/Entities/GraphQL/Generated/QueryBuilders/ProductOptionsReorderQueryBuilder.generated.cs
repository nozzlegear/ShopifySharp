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

public class ProductOptionsReorderQueryBuilder() : GraphQueryBuilder<ProductOptionsReorderPayload>("productOptionsReorder"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductOptionsReorderQueryBuilder AddArgumentOptions(ICollection<OptionReorderInput>? options)
    {
        AddArgument("options", options);
        return this;
    }

    public ProductOptionsReorderQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }
}