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

public class AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder() : GraphQueryBuilder<AbandonmentUpdateActivitiesDeliveryStatusesPayload>("abandonmentUpdateActivitiesDeliveryStatusesPayload")
{
    public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder AddFieldAbandonment(Func<AbandonmentQueryBuilder, AbandonmentQueryBuilder> build)
    {
        AddField<Abandonment, AbandonmentQueryBuilder>("abandonment", build);
        return this;
    }

    public AbandonmentUpdateActivitiesDeliveryStatusesPayloadQueryBuilder AddFieldUserErrors(Func<AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder, AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder> build)
    {
        AddField<AbandonmentUpdateActivitiesDeliveryStatusesUserError, AbandonmentUpdateActivitiesDeliveryStatusesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}