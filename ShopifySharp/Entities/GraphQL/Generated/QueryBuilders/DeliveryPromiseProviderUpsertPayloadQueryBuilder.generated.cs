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

public class DeliveryPromiseProviderUpsertPayloadQueryBuilder() : GraphQueryBuilder<DeliveryPromiseProviderUpsertPayload>("deliveryPromiseProviderUpsertPayload")
{
    public DeliveryPromiseProviderUpsertPayloadQueryBuilder AddFieldDeliveryPromiseProvider(Func<DeliveryPromiseProviderQueryBuilder, DeliveryPromiseProviderQueryBuilder> build)
    {
        AddField<DeliveryPromiseProvider, DeliveryPromiseProviderQueryBuilder>("deliveryPromiseProvider", build);
        return this;
    }

    public DeliveryPromiseProviderUpsertPayloadQueryBuilder AddFieldUserErrors(Func<DeliveryPromiseProviderUpsertUserErrorQueryBuilder, DeliveryPromiseProviderUpsertUserErrorQueryBuilder> build)
    {
        AddField<DeliveryPromiseProviderUpsertUserError, DeliveryPromiseProviderUpsertUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}