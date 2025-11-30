#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DeliveryPromiseProviderUpsertUserErrorQueryBuilder() : GraphQueryBuilder<DeliveryPromiseProviderUpsertUserError>("query deliveryPromiseProviderUpsertUserError")
{
    public DeliveryPromiseProviderUpsertUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public DeliveryPromiseProviderUpsertUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DeliveryPromiseProviderUpsertUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}