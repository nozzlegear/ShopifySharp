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

public class LocationDeactivateUserErrorQueryBuilder() : GraphQueryBuilder<LocationDeactivateUserError>("query locationDeactivateUserError")
{
    public LocationDeactivateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public LocationDeactivateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public LocationDeactivateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}