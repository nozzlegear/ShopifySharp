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

public class ReverseFulfillmentOrderDisposePayloadQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderDisposePayload>("reverseFulfillmentOrderDisposePayload")
{
    public ReverseFulfillmentOrderDisposePayloadQueryBuilder AddFieldReverseFulfillmentOrderLineItems(Func<ReverseFulfillmentOrderLineItemQueryBuilder, ReverseFulfillmentOrderLineItemQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderLineItem, ReverseFulfillmentOrderLineItemQueryBuilder>("reverseFulfillmentOrderLineItems", build);
        return this;
    }

    public ReverseFulfillmentOrderDisposePayloadQueryBuilder AddFieldUserErrors(Func<ReturnUserErrorQueryBuilder, ReturnUserErrorQueryBuilder> build)
    {
        AddField<ReturnUserError, ReturnUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}