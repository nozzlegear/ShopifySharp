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

public class Model3dQueryBuilder() : GraphQueryBuilder<Model3d>("query model3d")
{
    public Model3dQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public Model3dQueryBuilder AddFieldBoundingBox()
    {
        AddField("boundingBox");
        return this;
    }

    public Model3dQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public Model3dQueryBuilder AddFieldFileErrors()
    {
        AddField("fileErrors");
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

    public Model3dQueryBuilder AddFieldMediaErrors()
    {
        AddField("mediaErrors");
        return this;
    }

    public Model3dQueryBuilder AddFieldMediaWarnings()
    {
        AddField("mediaWarnings");
        return this;
    }

    public Model3dQueryBuilder AddFieldOriginalSource()
    {
        AddField("originalSource");
        return this;
    }

    public Model3dQueryBuilder AddFieldPreview()
    {
        AddField("preview");
        return this;
    }

    public Model3dQueryBuilder AddFieldSources()
    {
        AddField("sources");
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