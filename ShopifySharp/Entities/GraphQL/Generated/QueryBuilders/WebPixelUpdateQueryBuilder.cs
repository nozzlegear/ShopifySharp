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

public class WebPixelUpdateQueryBuilder() : GraphQueryBuilder<WebPixelUpdatePayload>("query webPixelUpdate")
{
    public WebPixelUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public WebPixelUpdateQueryBuilder AddArgumentWebPixel(WebPixelInput? webPixel)
    {
        AddArgument("webPixel", webPixel);
        return this;
    }
}