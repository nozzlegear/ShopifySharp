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

public class DeliveryPromiseSettingQueryBuilder() : GraphQueryBuilder<DeliveryPromiseSetting>("query deliveryPromiseSetting")
{
    public DeliveryPromiseSettingQueryBuilder AddFieldDeliveryDatesEnabled()
    {
        AddField("deliveryDatesEnabled");
        return this;
    }

    public DeliveryPromiseSettingQueryBuilder AddFieldProcessingTime()
    {
        AddField("processingTime");
        return this;
    }
}