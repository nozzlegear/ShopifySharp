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

public class LocationEditUserErrorQueryBuilder() : GraphQueryBuilder<LocationEditUserError>("query locationEditUserError")
{
    public LocationEditUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public LocationEditUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public LocationEditUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}