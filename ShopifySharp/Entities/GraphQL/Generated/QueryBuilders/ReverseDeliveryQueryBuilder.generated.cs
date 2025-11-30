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

public class ReverseDeliveryQueryBuilder() : GraphQueryBuilder<ReverseDelivery>("reverseDelivery")
{
    public ReverseDeliveryQueryBuilder AddUnionCaseDeliverable(Func<ReverseDeliveryShippingDeliverableQueryBuilder, ReverseDeliveryShippingDeliverableQueryBuilder> build)
    {
        AddUnion<ReverseDeliveryShippingDeliverable, ReverseDeliveryShippingDeliverableQueryBuilder>("deliverable", build);
        return this;
    }

    public ReverseDeliveryQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseDeliveryQueryBuilder AddFieldReverseDeliveryLineItems(Func<ReverseDeliveryLineItemConnectionQueryBuilder, ReverseDeliveryLineItemConnectionQueryBuilder> build)
    {
        AddField<ReverseDeliveryLineItemConnection, ReverseDeliveryLineItemConnectionQueryBuilder>("reverseDeliveryLineItems", build);
        return this;
    }

    public ReverseDeliveryQueryBuilder AddFieldReverseFulfillmentOrder(Func<ReverseFulfillmentOrderQueryBuilder, ReverseFulfillmentOrderQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrder, ReverseFulfillmentOrderQueryBuilder>("reverseFulfillmentOrder", build);
        return this;
    }
}