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

public class LocationDeletePayloadQueryBuilder() : GraphQueryBuilder<LocationDeletePayload>("locationDeletePayload")
{
    public LocationDeletePayloadQueryBuilder AddFieldDeletedLocationId()
    {
        AddField("deletedLocationId");
        return this;
    }

    public LocationDeletePayloadQueryBuilder AddFieldLocationDeleteUserErrors(Func<LocationDeleteUserErrorQueryBuilder, LocationDeleteUserErrorQueryBuilder> build)
    {
        AddField<LocationDeleteUserError, LocationDeleteUserErrorQueryBuilder>("locationDeleteUserErrors", build);
        return this;
    }
}