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

public class VideoSourceQueryBuilder() : GraphQueryBuilder<VideoSource>("videoSource")
{
    public VideoSourceQueryBuilder AddFieldFileSize()
    {
        AddField("fileSize");
        return this;
    }

    public VideoSourceQueryBuilder AddFieldFormat()
    {
        AddField("format");
        return this;
    }

    public VideoSourceQueryBuilder AddFieldHeight()
    {
        AddField("height");
        return this;
    }

    public VideoSourceQueryBuilder AddFieldMimeType()
    {
        AddField("mimeType");
        return this;
    }

    public VideoSourceQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }

    public VideoSourceQueryBuilder AddFieldWidth()
    {
        AddField("width");
        return this;
    }
}