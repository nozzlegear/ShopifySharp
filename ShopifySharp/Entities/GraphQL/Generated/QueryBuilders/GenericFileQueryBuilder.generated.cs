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

public class GenericFileQueryBuilder() : GraphQueryBuilder<GenericFile>("genericFile")
{
    public GenericFileQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public GenericFileQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public GenericFileQueryBuilder AddFieldFileErrors(Func<FileErrorQueryBuilder, FileErrorQueryBuilder> build)
    {
        AddField<FileError, FileErrorQueryBuilder>("fileErrors", build);
        return this;
    }

    public GenericFileQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public GenericFileQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public GenericFileQueryBuilder AddFieldMimeType()
    {
        AddField("mimeType");
        return this;
    }

    public GenericFileQueryBuilder AddFieldOriginalFileSize()
    {
        AddField("originalFileSize");
        return this;
    }

    public GenericFileQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public GenericFileQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public GenericFileQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}