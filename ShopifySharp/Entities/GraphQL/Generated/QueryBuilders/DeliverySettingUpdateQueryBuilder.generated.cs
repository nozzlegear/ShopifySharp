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

public class DeliverySettingUpdateQueryBuilder() : GraphQueryBuilder<DeliverySettingUpdatePayload>("deliverySettingUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DeliverySettingUpdateQueryBuilder AddArgumentSetting(DeliverySettingInput? setting)
    {
        AddArgument("setting", setting);
        return this;
    }
}