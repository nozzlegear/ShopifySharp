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

public class DeliveryProfileUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliveryProfileUpdatePayload>("deliveryProfileUpdatePayload")
{
    public DeliveryProfileUpdatePayloadQueryBuilder AddFieldProfile(Func<DeliveryProfileQueryBuilder, DeliveryProfileQueryBuilder> build)
    {
        AddField<DeliveryProfile, DeliveryProfileQueryBuilder>("profile", build);
        return this;
    }

    public DeliveryProfileUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}