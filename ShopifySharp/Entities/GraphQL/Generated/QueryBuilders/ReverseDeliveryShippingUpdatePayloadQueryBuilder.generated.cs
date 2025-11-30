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

public class ReverseDeliveryShippingUpdatePayloadQueryBuilder() : GraphQueryBuilder<ReverseDeliveryShippingUpdatePayload>("reverseDeliveryShippingUpdatePayload")
{
    public ReverseDeliveryShippingUpdatePayloadQueryBuilder AddFieldReverseDelivery(Func<ReverseDeliveryQueryBuilder, ReverseDeliveryQueryBuilder> build)
    {
        AddField<ReverseDelivery, ReverseDeliveryQueryBuilder>("reverseDelivery", build);
        return this;
    }

    public ReverseDeliveryShippingUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ReturnUserErrorQueryBuilder, ReturnUserErrorQueryBuilder> build)
    {
        AddField<ReturnUserError, ReturnUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}