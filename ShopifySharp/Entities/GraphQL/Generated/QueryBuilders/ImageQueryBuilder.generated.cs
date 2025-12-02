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

public class ImageQueryBuilder() : GraphQueryBuilder<Image>("image")
{
    public ImageQueryBuilder AddFieldAltText()
    {
        AddField("altText");
        return this;
    }

    public ImageQueryBuilder AddFieldHeight()
    {
        AddField("height");
        return this;
    }

    public ImageQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ImageQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public ImageQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }

    [Obsolete("Use `url` instead.")]
    public ImageQueryBuilder AddFieldOriginalSrc()
    {
        AddField("originalSrc");
        return this;
    }

    [Obsolete("Use `url` instead.")]
    public ImageQueryBuilder AddFieldSrc()
    {
        AddField("src");
        return this;
    }

    public ImageQueryBuilder AddFieldThumbhash()
    {
        AddField("thumbhash");
        return this;
    }

    [Obsolete("Use `url(transform:)` instead")]
    public ImageQueryBuilder AddFieldTransformedSrc()
    {
        AddField("transformedSrc");
        return this;
    }

    public ImageQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }

    public ImageQueryBuilder AddFieldWidth()
    {
        AddField("width");
        return this;
    }
}