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

public class DeliveryLocationGroupQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroup>("deliveryLocationGroup")
{
    public DeliveryLocationGroupQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DeliveryLocationGroupQueryBuilder AddFieldLocations(Func<LocationConnectionQueryBuilder, LocationConnectionQueryBuilder> build)
    {
        AddField<LocationConnection, LocationConnectionQueryBuilder>("locations", build);
        return this;
    }

    public DeliveryLocationGroupQueryBuilder AddFieldLocationsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("locationsCount", build);
        return this;
    }
}