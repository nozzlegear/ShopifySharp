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

public class PaymentCustomizationActivationQueryBuilder() : GraphQueryBuilder<PaymentCustomizationActivationPayload>("paymentCustomizationActivation"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PaymentCustomizationActivationQueryBuilder AddArgumentEnabled(bool? enabled)
    {
        AddArgument("enabled", enabled);
        return this;
    }

    public PaymentCustomizationActivationQueryBuilder AddArgumentIds(ICollection<string>? ids)
    {
        AddArgument("ids", ids);
        return this;
    }
}