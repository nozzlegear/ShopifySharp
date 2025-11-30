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

public class DeliveryLocationGroupZoneQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroupZone>("deliveryLocationGroupZone")
{
    public DeliveryLocationGroupZoneQueryBuilder AddFieldMethodDefinitionCounts(Func<DeliveryMethodDefinitionCountsQueryBuilder, DeliveryMethodDefinitionCountsQueryBuilder> build)
    {
        AddField<DeliveryMethodDefinitionCounts, DeliveryMethodDefinitionCountsQueryBuilder>("methodDefinitionCounts", build);
        return this;
    }

    public DeliveryLocationGroupZoneQueryBuilder AddFieldMethodDefinitions(Func<DeliveryMethodDefinitionConnectionQueryBuilder, DeliveryMethodDefinitionConnectionQueryBuilder> build)
    {
        AddField<DeliveryMethodDefinitionConnection, DeliveryMethodDefinitionConnectionQueryBuilder>("methodDefinitions", build);
        return this;
    }

    public DeliveryLocationGroupZoneQueryBuilder AddFieldZone(Func<DeliveryZoneQueryBuilder, DeliveryZoneQueryBuilder> build)
    {
        AddField<DeliveryZone, DeliveryZoneQueryBuilder>("zone", build);
        return this;
    }
}