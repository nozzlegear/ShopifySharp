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

public class LocationDeactivatePayloadQueryBuilder() : GraphQueryBuilder<LocationDeactivatePayload>("locationDeactivatePayload")
{
    public LocationDeactivatePayloadQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public LocationDeactivatePayloadQueryBuilder AddFieldLocationDeactivateUserErrors(Func<LocationDeactivateUserErrorQueryBuilder, LocationDeactivateUserErrorQueryBuilder> build)
    {
        AddField<LocationDeactivateUserError, LocationDeactivateUserErrorQueryBuilder>("locationDeactivateUserErrors", build);
        return this;
    }
}