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

public class ReverseFulfillmentOrderQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrder>("reverseFulfillmentOrder")
{
    public ReverseFulfillmentOrderQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldLineItems(Func<ReverseFulfillmentOrderLineItemConnectionQueryBuilder, ReverseFulfillmentOrderLineItemConnectionQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderLineItemConnection, ReverseFulfillmentOrderLineItemConnectionQueryBuilder>("lineItems", build);
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldReverseDeliveries(Func<ReverseDeliveryConnectionQueryBuilder, ReverseDeliveryConnectionQueryBuilder> build)
    {
        AddField<ReverseDeliveryConnection, ReverseDeliveryConnectionQueryBuilder>("reverseDeliveries", build);
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ReverseFulfillmentOrderQueryBuilder AddFieldThirdPartyConfirmation(Func<ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder, ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderThirdPartyConfirmation, ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder>("thirdPartyConfirmation", build);
        return this;
    }
}