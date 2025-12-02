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

public class FileQueryBuilder() : GraphQueryBuilder<IFile>("file")
{
    public FileQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public FileQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public FileQueryBuilder AddFieldFileErrors(Func<FileErrorQueryBuilder, FileErrorQueryBuilder> build)
    {
        AddField<FileError, FileErrorQueryBuilder>("fileErrors", build);
        return this;
    }

    public FileQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public FileQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FileQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public FileQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}