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

public class ProductVariantByIdentifierQueryBuilder() : GraphQueryBuilder<ProductVariant>("productVariantByIdentifier"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public ProductVariantByIdentifierQueryBuilder AddArgumentIdentifier(ProductVariantIdentifierInput? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }
}