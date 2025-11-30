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

public class DeliveryProfileLocationGroupQueryBuilder() : GraphQueryBuilder<DeliveryProfileLocationGroup>("deliveryProfileLocationGroup")
{
    public DeliveryProfileLocationGroupQueryBuilder AddFieldCountriesInAnyZone(Func<DeliveryCountryAndZoneQueryBuilder, DeliveryCountryAndZoneQueryBuilder> build)
    {
        AddField<DeliveryCountryAndZone, DeliveryCountryAndZoneQueryBuilder>("countriesInAnyZone", build);
        return this;
    }

    public DeliveryProfileLocationGroupQueryBuilder AddFieldLocationGroup(Func<DeliveryLocationGroupQueryBuilder, DeliveryLocationGroupQueryBuilder> build)
    {
        AddField<DeliveryLocationGroup, DeliveryLocationGroupQueryBuilder>("locationGroup", build);
        return this;
    }

    public DeliveryProfileLocationGroupQueryBuilder AddFieldLocationGroupZones(Func<DeliveryLocationGroupZoneConnectionQueryBuilder, DeliveryLocationGroupZoneConnectionQueryBuilder> build)
    {
        AddField<DeliveryLocationGroupZoneConnection, DeliveryLocationGroupZoneConnectionQueryBuilder>("locationGroupZones", build);
        return this;
    }
}