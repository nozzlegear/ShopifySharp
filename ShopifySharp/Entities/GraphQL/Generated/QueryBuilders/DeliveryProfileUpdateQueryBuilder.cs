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

public class DeliveryProfileUpdateQueryBuilder() : GraphQueryBuilder<DeliveryProfileUpdatePayload>("query deliveryProfileUpdate")
{
    public DeliveryProfileUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public DeliveryProfileUpdateQueryBuilder AddArgumentLeaveLegacyModeProfiles(bool? leaveLegacyModeProfiles)
    {
        AddArgument("leaveLegacyModeProfiles", leaveLegacyModeProfiles);
        return this;
    }

    public DeliveryProfileUpdateQueryBuilder AddArgumentProfile(DeliveryProfileInput? profile)
    {
        AddArgument("profile", profile);
        return this;
    }
}