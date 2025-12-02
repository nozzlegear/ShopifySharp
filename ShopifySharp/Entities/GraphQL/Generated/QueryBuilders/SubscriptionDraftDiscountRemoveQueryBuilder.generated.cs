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

public class SubscriptionDraftDiscountRemoveQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountRemovePayload>("subscriptionDraftDiscountRemove"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public SubscriptionDraftDiscountRemoveQueryBuilder AddArgumentDiscountId(string? discountId)
    {
        AddArgument("discountId", discountId);
        return this;
    }

    public SubscriptionDraftDiscountRemoveQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }
}