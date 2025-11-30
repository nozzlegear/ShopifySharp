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

[Obsolete("Use `abandonmentUpdateActivitiesDeliveryStatuses` instead.")]
public class AbandonmentEmailStateUpdateQueryBuilder() : GraphQueryBuilder<AbandonmentEmailStateUpdatePayload>("abandonmentEmailStateUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public AbandonmentEmailStateUpdateQueryBuilder AddArgumentEmailSentAt(DateTime? emailSentAt)
    {
        AddArgument("emailSentAt", emailSentAt);
        return this;
    }

    public AbandonmentEmailStateUpdateQueryBuilder AddArgumentEmailState(AbandonmentEmailState? emailState)
    {
        AddArgument("emailState", emailState);
        return this;
    }

    public AbandonmentEmailStateUpdateQueryBuilder AddArgumentEmailStateChangeReason(string? emailStateChangeReason)
    {
        AddArgument("emailStateChangeReason", emailStateChangeReason);
        return this;
    }

    public AbandonmentEmailStateUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}