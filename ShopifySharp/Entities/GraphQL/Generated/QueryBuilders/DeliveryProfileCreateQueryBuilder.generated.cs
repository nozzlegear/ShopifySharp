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

public class DeliveryProfileCreateQueryBuilder() : GraphQueryBuilder<DeliveryProfileCreatePayload>("deliveryProfileCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DeliveryProfileCreateQueryBuilder AddArgumentProfile(DeliveryProfileInput? profile)
    {
        AddArgument("profile", profile);
        return this;
    }
}