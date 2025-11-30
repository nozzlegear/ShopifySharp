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

public class ReverseFulfillmentOrderLineItemQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderLineItem>("reverseFulfillmentOrderLineItem")
{
    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldDispositions(Func<ReverseFulfillmentOrderDispositionQueryBuilder, ReverseFulfillmentOrderDispositionQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderDisposition, ReverseFulfillmentOrderDispositionQueryBuilder>("dispositions", build);
        return this;
    }

    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldFulfillmentLineItem(Func<FulfillmentLineItemQueryBuilder, FulfillmentLineItemQueryBuilder> build)
    {
        AddField<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>("fulfillmentLineItem", build);
        return this;
    }

    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReverseFulfillmentOrderLineItemQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }
}