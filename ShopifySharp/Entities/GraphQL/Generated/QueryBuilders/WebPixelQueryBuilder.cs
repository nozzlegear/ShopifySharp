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

public class WebPixelQueryBuilder() : GraphQueryBuilder<WebPixel>("query webPixel")
{
    public WebPixelQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public WebPixelQueryBuilder AddFieldSettings()
    {
        AddField("settings");
        return this;
    }
}