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

public class DeliveryLegacyModeBlockedQueryBuilder() : GraphQueryBuilder<DeliveryLegacyModeBlocked>("deliveryLegacyModeBlocked")
{
    public DeliveryLegacyModeBlockedQueryBuilder AddFieldBlocked()
    {
        AddField("blocked");
        return this;
    }

    public DeliveryLegacyModeBlockedQueryBuilder AddFieldReasons()
    {
        AddField("reasons");
        return this;
    }
}