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

public class DeliveryCustomizationDeletePayloadQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationDeletePayload>("deliveryCustomizationDeletePayload")
{
    public DeliveryCustomizationDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public DeliveryCustomizationDeletePayloadQueryBuilder AddFieldUserErrors(Func<DeliveryCustomizationErrorQueryBuilder, DeliveryCustomizationErrorQueryBuilder> build)
    {
        AddField<DeliveryCustomizationError, DeliveryCustomizationErrorQueryBuilder>("userErrors", build);
        return this;
    }
}