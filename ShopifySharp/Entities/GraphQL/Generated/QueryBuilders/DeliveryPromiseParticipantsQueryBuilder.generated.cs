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

public class DeliveryPromiseParticipantsQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantConnection>("deliveryPromiseParticipants"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentBrandedPromiseHandle(string? brandedPromiseHandle)
    {
        AddArgument("brandedPromiseHandle", brandedPromiseHandle);
        return this;
    }

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentOwnerIds(ICollection<string>? ownerIds)
    {
        AddArgument("ownerIds", ownerIds);
        return this;
    }

    public DeliveryPromiseParticipantsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}