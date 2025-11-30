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

public class LocationAddPayloadQueryBuilder() : GraphQueryBuilder<LocationAddPayload>("locationAddPayload")
{
    public LocationAddPayloadQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public LocationAddPayloadQueryBuilder AddFieldUserErrors(Func<LocationAddUserErrorQueryBuilder, LocationAddUserErrorQueryBuilder> build)
    {
        AddField<LocationAddUserError, LocationAddUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}