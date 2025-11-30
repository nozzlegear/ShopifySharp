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

public class Model3dQueryBuilder() : GraphQueryBuilder<Model3d>("model3d")
{
    public Model3dQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public Model3dQueryBuilder AddFieldBoundingBox(Func<Model3dBoundingBoxQueryBuilder, Model3dBoundingBoxQueryBuilder> build)
    {
        AddField<Model3dBoundingBox, Model3dBoundingBoxQueryBuilder>("boundingBox", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public Model3dQueryBuilder AddFieldFileErrors(Func<FileErrorQueryBuilder, FileErrorQueryBuilder> build)
    {
        AddField<FileError, FileErrorQueryBuilder>("fileErrors", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldFilename()
    {
        AddField("filename");
        return this;
    }

    public Model3dQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public Model3dQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public Model3dQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public Model3dQueryBuilder AddFieldMediaErrors(Func<MediaErrorQueryBuilder, MediaErrorQueryBuilder> build)
    {
        AddField<MediaError, MediaErrorQueryBuilder>("mediaErrors", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldMediaWarnings(Func<MediaWarningQueryBuilder, MediaWarningQueryBuilder> build)
    {
        AddField<MediaWarning, MediaWarningQueryBuilder>("mediaWarnings", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldOriginalSource(Func<Model3dSourceQueryBuilder, Model3dSourceQueryBuilder> build)
    {
        AddField<Model3dSource, Model3dSourceQueryBuilder>("originalSource", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldPreview(Func<MediaPreviewImageQueryBuilder, MediaPreviewImageQueryBuilder> build)
    {
        AddField<MediaPreviewImage, MediaPreviewImageQueryBuilder>("preview", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldSources(Func<Model3dSourceQueryBuilder, Model3dSourceQueryBuilder> build)
    {
        AddField<Model3dSource, Model3dSourceQueryBuilder>("sources", build);
        return this;
    }

    public Model3dQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public Model3dQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}