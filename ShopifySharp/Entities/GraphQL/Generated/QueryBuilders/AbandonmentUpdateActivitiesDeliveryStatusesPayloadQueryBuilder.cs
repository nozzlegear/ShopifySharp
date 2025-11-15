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

public class AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder() : GraphQueryBuilder<AbandonmentUpdateActivitiesDeliveryStatusesPayload>("query abandonmentUpdateActivitiesDeliveryStatusesPayload")
{
    public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder AddFieldAbandonment()
    {
        AddField("abandonment");
        return this;
    }

    public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}