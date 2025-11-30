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

public class ExternalVideoQueryBuilder() : GraphQueryBuilder<ExternalVideo>("externalVideo")
{
    public ExternalVideoQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Use `originUrl` instead.")]
    public ExternalVideoQueryBuilder AddFieldEmbeddedUrl()
    {
        AddField("embeddedUrl");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldEmbedUrl()
    {
        AddField("embedUrl");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldFileErrors(Func<FileErrorQueryBuilder, FileErrorQueryBuilder> build)
    {
        AddField<FileError, FileErrorQueryBuilder>("fileErrors", build);
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldHost()
    {
        AddField("host");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldMediaErrors(Func<MediaErrorQueryBuilder, MediaErrorQueryBuilder> build)
    {
        AddField<MediaError, MediaErrorQueryBuilder>("mediaErrors", build);
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldMediaWarnings(Func<MediaWarningQueryBuilder, MediaWarningQueryBuilder> build)
    {
        AddField<MediaWarning, MediaWarningQueryBuilder>("mediaWarnings", build);
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldOriginUrl()
    {
        AddField("originUrl");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ExternalVideoQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}