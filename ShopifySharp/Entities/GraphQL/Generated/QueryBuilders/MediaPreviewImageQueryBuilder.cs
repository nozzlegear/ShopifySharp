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

public class MediaPreviewImageQueryBuilder() : GraphQueryBuilder<MediaPreviewImage>("query mediaPreviewImage")
{
    public MediaPreviewImageQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public MediaPreviewImageQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}