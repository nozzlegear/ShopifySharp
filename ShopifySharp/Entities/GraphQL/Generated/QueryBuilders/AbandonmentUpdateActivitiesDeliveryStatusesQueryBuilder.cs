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

public class AbandonmentUpdateActivitiesDeliveryStatusesQueryBuilder() : GraphQueryBuilder<AbandonmentUpdateActivitiesDeliveryStatusesPayload>("query abandonmentUpdateActivitiesDeliveryStatuses")
{
    public AbandonmentUpdateActivitiesDeliveryStatusesQueryBuilder AddArgumentAbandonmentId(string? abandonmentId)
    {
        AddArgument("abandonmentId", abandonmentId);
        return this;
    }

    public AbandonmentUpdateActivitiesDeliveryStatusesQueryBuilder AddArgumentDeliveredAt(DateTime? deliveredAt)
    {
        AddArgument("deliveredAt", deliveredAt);
        return this;
    }

    public AbandonmentUpdateActivitiesDeliveryStatusesQueryBuilder AddArgumentDeliveryStatus(AbandonmentDeliveryState? deliveryStatus)
    {
        AddArgument("deliveryStatus", deliveryStatus);
        return this;
    }

    public AbandonmentUpdateActivitiesDeliveryStatusesQueryBuilder AddArgumentDeliveryStatusChangeReason(string? deliveryStatusChangeReason)
    {
        AddArgument("deliveryStatusChangeReason", deliveryStatusChangeReason);
        return this;
    }

    public AbandonmentUpdateActivitiesDeliveryStatusesQueryBuilder AddArgumentMarketingActivityId(string? marketingActivityId)
    {
        AddArgument("marketingActivityId", marketingActivityId);
        return this;
    }
}