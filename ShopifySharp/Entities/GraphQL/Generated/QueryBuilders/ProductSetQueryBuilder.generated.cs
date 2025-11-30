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

public class ProductSetQueryBuilder() : GraphQueryBuilder<ProductSetPayload>("productSet"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ProductSetQueryBuilder AddArgumentIdentifier(ProductSetIdentifiers? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }

    public ProductSetQueryBuilder AddArgumentInput(ProductSetInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public ProductSetQueryBuilder AddArgumentSynchronous(bool? synchronous)
    {
        AddArgument("synchronous", synchronous);
        return this;
    }
}