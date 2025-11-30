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

public class MediaPreviewImageQueryBuilder() : GraphQueryBuilder<MediaPreviewImage>("mediaPreviewImage")
{
    public MediaPreviewImageQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public MediaPreviewImageQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}