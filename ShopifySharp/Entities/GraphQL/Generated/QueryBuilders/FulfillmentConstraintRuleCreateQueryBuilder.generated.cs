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

public class FulfillmentConstraintRuleCreateQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRuleCreatePayload>("fulfillmentConstraintRuleCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentConstraintRuleCreateQueryBuilder AddArgumentDeliveryMethodTypes(ICollection<DeliveryMethodType>? deliveryMethodTypes)
    {
        AddArgument("deliveryMethodTypes", deliveryMethodTypes);
        return this;
    }

    public FulfillmentConstraintRuleCreateQueryBuilder AddArgumentFunctionId(string? functionId)
    {
        AddArgument("functionId", functionId);
        return this;
    }

    public FulfillmentConstraintRuleCreateQueryBuilder AddArgumentMetafields(ICollection<MetafieldInput>? metafields)
    {
        AddArgument("metafields", metafields);
        return this;
    }
}