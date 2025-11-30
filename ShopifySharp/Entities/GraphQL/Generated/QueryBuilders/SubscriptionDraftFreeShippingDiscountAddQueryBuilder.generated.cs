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

public class SubscriptionDraftFreeShippingDiscountAddQueryBuilder() : GraphQueryBuilder<SubscriptionDraftFreeShippingDiscountAddPayload>("subscriptionDraftFreeShippingDiscountAdd"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public SubscriptionDraftFreeShippingDiscountAddQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftFreeShippingDiscountAddQueryBuilder AddArgumentInput(SubscriptionFreeShippingDiscountInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}