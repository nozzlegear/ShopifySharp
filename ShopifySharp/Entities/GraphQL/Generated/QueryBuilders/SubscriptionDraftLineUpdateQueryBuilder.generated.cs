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

public class SubscriptionDraftLineUpdateQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineUpdatePayload>("subscriptionDraftLineUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public SubscriptionDraftLineUpdateQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftLineUpdateQueryBuilder AddArgumentInput(SubscriptionLineUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public SubscriptionDraftLineUpdateQueryBuilder AddArgumentLineId(string? lineId)
    {
        AddArgument("lineId", lineId);
        return this;
    }
}