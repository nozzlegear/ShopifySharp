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

public class LocationAddUserErrorQueryBuilder() : GraphQueryBuilder<LocationAddUserError>("query locationAddUserError")
{
    public LocationAddUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public LocationAddUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public LocationAddUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}