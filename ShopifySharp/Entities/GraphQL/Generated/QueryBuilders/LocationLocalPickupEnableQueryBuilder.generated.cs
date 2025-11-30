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

public class LocationLocalPickupEnableQueryBuilder() : GraphQueryBuilder<LocationLocalPickupEnablePayload>("locationLocalPickupEnable"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public LocationLocalPickupEnableQueryBuilder AddArgumentLocalPickupSettings(DeliveryLocationLocalPickupEnableInput? localPickupSettings)
    {
        AddArgument("localPickupSettings", localPickupSettings);
        return this;
    }
}