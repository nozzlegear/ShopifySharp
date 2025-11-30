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

public class LocationSnapshotQueryBuilder() : GraphQueryBuilder<LocationSnapshot>("query locationSnapshot")
{
    public LocationSnapshotQueryBuilder AddFieldAddress()
    {
        AddField("address");
        return this;
    }

    public LocationSnapshotQueryBuilder AddFieldLocation()
    {
        AddField("location");
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