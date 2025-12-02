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

public class DeliverySettingUpdatePayloadQueryBuilder() : GraphQueryBuilder<DeliverySettingUpdatePayload>("deliverySettingUpdatePayload")
{
    public DeliverySettingUpdatePayloadQueryBuilder AddFieldSetting(Func<DeliverySettingQueryBuilder, DeliverySettingQueryBuilder> build)
    {
        AddField<DeliverySetting, DeliverySettingQueryBuilder>("setting", build);
        return this;
    }

    public DeliverySettingUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}