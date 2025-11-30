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

public class VideoQueryBuilder() : GraphQueryBuilder<Video>("video")
{
    public VideoQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public VideoQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public VideoQueryBuilder AddFieldDuration()
    {
        AddField("duration");
        return this;
    }

    public VideoQueryBuilder AddFieldFileErrors(Func<FileErrorQueryBuilder, FileErrorQueryBuilder> build)
    {
        AddField<FileError, FileErrorQueryBuilder>("fileErrors", build);
        return this;
    }

    public VideoQueryBuilder AddFieldFilename()
    {
        AddField("filename");
        return this;
    }

    public VideoQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public VideoQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public VideoQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public VideoQueryBuilder AddFieldMediaErrors(Func<MediaErrorQueryBuilder, MediaErrorQueryBuilder> build)
    {
        AddField<MediaError, MediaErrorQueryBuilder>("mediaErrors", build);
        return this;
    }

    public VideoQueryBuilder AddFieldMediaWarnings(Func<MediaWarningQueryBuilder, MediaWarningQueryBuilder> build)
    {
        AddField<MediaWarning, MediaWarningQueryBuilder>("mediaWarnings", build);
        return this;
    }

    public VideoQueryBuilder AddFieldOriginalSource(Func<VideoSourceQueryBuilder, VideoSourceQueryBuilder> build)
    {
        AddField<VideoSource, VideoSourceQueryBuilder>("originalSource", build);
        return this;
    }

    public VideoQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public VideoQueryBuilder AddFieldSources(Func<VideoSourceQueryBuilder, VideoSourceQueryBuilder> build)
    {
        AddField<VideoSource, VideoSourceQueryBuilder>("sources", build);
        return this;
    }

    public VideoQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public VideoQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}