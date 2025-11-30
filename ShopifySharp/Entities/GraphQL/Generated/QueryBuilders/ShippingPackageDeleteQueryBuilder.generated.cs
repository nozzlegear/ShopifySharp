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

public class ShippingPackageDeleteQueryBuilder() : GraphQueryBuilder<ShippingPackageDeletePayload>("shippingPackageDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ShippingPackageDeleteQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}