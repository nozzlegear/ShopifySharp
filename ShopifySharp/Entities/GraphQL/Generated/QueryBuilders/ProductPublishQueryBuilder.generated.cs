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

[Obsolete("Use `publishablePublish` instead.")]
public class ProductPublishQueryBuilder() : GraphQueryBuilder<ProductPublishPayload>("productPublish"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductPublishQueryBuilder AddArgumentInput(ProductPublishInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}