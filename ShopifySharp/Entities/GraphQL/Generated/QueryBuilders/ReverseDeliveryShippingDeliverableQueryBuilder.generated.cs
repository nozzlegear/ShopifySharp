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

public class ReverseDeliveryShippingDeliverableQueryBuilder() : GraphQueryBuilder<ReverseDeliveryShippingDeliverable>("reverseDeliveryShippingDeliverable")
{
    public ReverseDeliveryShippingDeliverableQueryBuilder AddFieldLabel(Func<ReverseDeliveryLabelV2QueryBuilder, ReverseDeliveryLabelV2QueryBuilder> build)
    {
        AddField<ReverseDeliveryLabelV2, ReverseDeliveryLabelV2QueryBuilder>("label", build);
        return this;
    }

    public ReverseDeliveryShippingDeliverableQueryBuilder AddFieldTracking(Func<ReverseDeliveryTrackingV2QueryBuilder, ReverseDeliveryTrackingV2QueryBuilder> build)
    {
        AddField<ReverseDeliveryTrackingV2, ReverseDeliveryTrackingV2QueryBuilder>("tracking", build);
        return this;
    }
}