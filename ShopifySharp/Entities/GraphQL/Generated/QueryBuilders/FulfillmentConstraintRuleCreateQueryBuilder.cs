#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FulfillmentConstraintRuleCreateQueryBuilder() : GraphQueryBuilder<FulfillmentConstraintRuleCreatePayload>("query fulfillmentConstraintRuleCreate")
{
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