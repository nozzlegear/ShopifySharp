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

public class MediaErrorQueryBuilder() : GraphQueryBuilder<MediaError>("query mediaError")
{
    public MediaErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MediaErrorQueryBuilder AddFieldDetails()
    {
        AddField("details");
        return this;
    }

    public MediaErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}