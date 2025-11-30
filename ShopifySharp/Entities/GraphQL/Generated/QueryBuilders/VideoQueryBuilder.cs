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

public class VideoQueryBuilder() : GraphQueryBuilder<Video>("query video")
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

    public VideoQueryBuilder AddFieldFileErrors()
    {
        AddField("fileErrors");
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

    public VideoQueryBuilder AddFieldMediaErrors()
    {
        AddField("mediaErrors");
        return this;
    }

    public VideoQueryBuilder AddFieldMediaWarnings()
    {
        AddField("mediaWarnings");
        return this;
    }

    public VideoQueryBuilder AddFieldOriginalSource()
    {
        AddField("originalSource");
        return this;
    }

    public VideoQueryBuilder AddFieldPreview()
    {
        AddField("preview");
        return this;
    }

    public VideoQueryBuilder AddFieldSources()
    {
        AddField("sources");
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