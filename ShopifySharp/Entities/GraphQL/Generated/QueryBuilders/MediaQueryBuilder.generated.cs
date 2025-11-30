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

public class MediaQueryBuilder() : GraphQueryBuilder<IMedia>("media")
{
    public MediaQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public MediaQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MediaQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public MediaQueryBuilder AddFieldMediaErrors(Func<MediaErrorQueryBuilder, MediaErrorQueryBuilder> build)
    {
        AddField<MediaError, MediaErrorQueryBuilder>("mediaErrors", build);
        return this;
    }

    public MediaQueryBuilder AddFieldMediaWarnings(Func<MediaWarningQueryBuilder, MediaWarningQueryBuilder> build)
    {
        AddField<MediaWarning, MediaWarningQueryBuilder>("mediaWarnings", build);
        return this;
    }

    public MediaQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public MediaQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}