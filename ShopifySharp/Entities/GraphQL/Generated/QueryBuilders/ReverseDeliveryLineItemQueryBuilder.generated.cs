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

public class ReverseDeliveryLineItemQueryBuilder() : GraphQueryBuilder<ReverseDeliveryLineItem>("reverseDeliveryLineItem")
{
    public ReverseDeliveryLineItemQueryBuilder AddFieldDispositions(Func<ReverseFulfillmentOrderDispositionQueryBuilder, ReverseFulfillmentOrderDispositionQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderDisposition, ReverseFulfillmentOrderDispositionQueryBuilder>("dispositions", build);
        return this;
    }

    public ReverseDeliveryLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseDeliveryLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ReverseDeliveryLineItemQueryBuilder AddFieldReverseFulfillmentOrderLineItem(Func<ReverseFulfillmentOrderLineItemQueryBuilder, ReverseFulfillmentOrderLineItemQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderLineItem, ReverseFulfillmentOrderLineItemQueryBuilder>("reverseFulfillmentOrderLineItem", build);
        return this;
    }
}