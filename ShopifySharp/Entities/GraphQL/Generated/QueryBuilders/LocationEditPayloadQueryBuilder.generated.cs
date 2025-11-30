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

public class LocationEditPayloadQueryBuilder() : GraphQueryBuilder<LocationEditPayload>("locationEditPayload")
{
    public LocationEditPayloadQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    public LocationEditPayloadQueryBuilder AddFieldUserErrors(Func<LocationEditUserErrorQueryBuilder, LocationEditUserErrorQueryBuilder> build)
    {
        AddField<LocationEditUserError, LocationEditUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}