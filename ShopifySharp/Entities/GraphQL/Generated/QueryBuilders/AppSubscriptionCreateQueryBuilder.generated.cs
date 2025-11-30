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

public class AppSubscriptionCreateQueryBuilder() : GraphQueryBuilder<AppSubscriptionCreatePayload>("appSubscriptionCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public AppSubscriptionCreateQueryBuilder AddArgumentLineItems(ICollection<AppSubscriptionLineItemInput>? lineItems)
    {
        AddArgument("lineItems", lineItems);
        return this;
    }

    public AppSubscriptionCreateQueryBuilder AddArgumentName(string? name)
    {
        AddArgument("name", name);
        return this;
    }

    public AppSubscriptionCreateQueryBuilder AddArgumentReplacementBehavior(AppSubscriptionReplacementBehavior? replacementBehavior)
    {
        AddArgument("replacementBehavior", replacementBehavior);
        return this;
    }

    public AppSubscriptionCreateQueryBuilder AddArgumentReturnUrl(string? returnUrl)
    {
        AddArgument("returnUrl", returnUrl);
        return this;
    }

    public AppSubscriptionCreateQueryBuilder AddArgumentTest(bool? test)
    {
        AddArgument("test", test);
        return this;
    }

    public AppSubscriptionCreateQueryBuilder AddArgumentTrialDays(int? trialDays)
    {
        AddArgument("trialDays", trialDays);
        return this;
    }
}