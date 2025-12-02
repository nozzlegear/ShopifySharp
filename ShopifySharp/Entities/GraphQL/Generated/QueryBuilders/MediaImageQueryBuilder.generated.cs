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

public class MediaImageQueryBuilder() : GraphQueryBuilder<MediaImage>("mediaImage")
{
    public MediaImageQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public MediaImageQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public MediaImageQueryBuilder AddFieldFileErrors(Func<FileErrorQueryBuilder, FileErrorQueryBuilder> build)
    {
        AddField<FileError, FileErrorQueryBuilder>("fileErrors", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public MediaImageQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MediaImageQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public MediaImageQueryBuilder AddFieldMediaErrors(Func<MediaErrorQueryBuilder, MediaErrorQueryBuilder> build)
    {
        AddField<MediaError, MediaErrorQueryBuilder>("mediaErrors", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldMediaWarnings(Func<MediaWarningQueryBuilder, MediaWarningQueryBuilder> build)
    {
        AddField<MediaWarning, MediaWarningQueryBuilder>("mediaWarnings", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldMimeType()
    {
        AddField("mimeType");
        return this;
    }

    public MediaImageQueryBuilder AddFieldOriginalSource(Func<MediaImageOriginalSourceQueryBuilder, MediaImageOriginalSourceQueryBuilder> build)
    {
        AddField<MediaImageOriginalSource, MediaImageOriginalSourceQueryBuilder>("originalSource", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public MediaImageQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public MediaImageQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}