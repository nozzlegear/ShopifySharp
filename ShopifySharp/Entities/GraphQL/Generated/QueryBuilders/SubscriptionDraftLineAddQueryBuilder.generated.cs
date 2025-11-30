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

public class SubscriptionDraftLineAddQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineAddPayload>("subscriptionDraftLineAdd"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public SubscriptionDraftLineAddQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftLineAddQueryBuilder AddArgumentInput(SubscriptionLineInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}