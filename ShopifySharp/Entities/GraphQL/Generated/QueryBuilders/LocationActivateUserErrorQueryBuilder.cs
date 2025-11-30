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

public class LocationActivateUserErrorQueryBuilder() : GraphQueryBuilder<LocationActivateUserError>("query locationActivateUserError")
{
    public LocationActivateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public LocationActivateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public LocationActivateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}