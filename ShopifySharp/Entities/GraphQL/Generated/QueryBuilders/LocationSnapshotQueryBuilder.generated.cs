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

public class LocationSnapshotQueryBuilder() : GraphQueryBuilder<LocationSnapshot>("locationSnapshot")
{
    public LocationSnapshotQueryBuilder AddFieldAddress(Func<LocationAddressQueryBuilder, LocationAddressQueryBuilder> build)
    {
        AddField<LocationAddress, LocationAddressQueryBuilder>("address", build);
        return this;
    }

    public LocationSnapshotQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public LocationSnapshotQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public LocationSnapshotQueryBuilder AddFieldSnapshottedAt()
    {
        AddField("snapshottedAt");
        return this;
    }
}