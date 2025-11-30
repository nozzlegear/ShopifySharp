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

public class DeliveryCustomizationUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationUpdatePayload>("deliveryCustomizationUpdatePayload")
{
    public DeliveryCustomizationUpdatePayloadQueryBuilder AddFieldDeliveryCustomization(Func<DeliveryCustomizationQueryBuilder, DeliveryCustomizationQueryBuilder> build)
    {
        AddField<DeliveryCustomization, DeliveryCustomizationQueryBuilder>("deliveryCustomization", build);
        return this;
    }

    public DeliveryCustomizationUpdatePayloadQueryBuilder AddFieldUserErrors(Func<DeliveryCustomizationErrorQueryBuilder, DeliveryCustomizationErrorQueryBuilder> build)
    {
        AddField<DeliveryCustomizationError, DeliveryCustomizationErrorQueryBuilder>("userErrors", build);
        return this;
    }
}