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

public class DeliverySettingQueryBuilder() : GraphQueryBuilder<DeliverySetting>("query deliverySetting")
{
    public DeliverySettingQueryBuilder AddFieldLegacyModeBlocked()
    {
        AddField("legacyModeBlocked");
        return this;
    }

    public DeliverySettingQueryBuilder AddFieldLegacyModeProfiles()
    {
        AddField("legacyModeProfiles");
        return this;
    }
}