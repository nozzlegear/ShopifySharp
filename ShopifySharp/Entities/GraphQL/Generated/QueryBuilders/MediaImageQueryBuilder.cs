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

public class MediaImageQueryBuilder() : GraphQueryBuilder<MediaImage>("query mediaImage")
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

    public MediaImageQueryBuilder AddFieldFileErrors()
    {
        AddField("fileErrors");
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

    public MediaImageQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public MediaImageQueryBuilder AddFieldMediaContentType()
    {
        AddField("mediaContentType");
        return this;
    }

    public MediaImageQueryBuilder AddFieldMediaErrors()
    {
        AddField("mediaErrors");
        return this;
    }

    public MediaImageQueryBuilder AddFieldMediaWarnings()
    {
        AddField("mediaWarnings");
        return this;
    }

    [Obsolete("No longer supported. Use metaobjects instead.")]
    public MediaImageQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    [Obsolete("No longer supported. Use metaobjects instead.")]
    public MediaImageQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public MediaImageQueryBuilder AddFieldMimeType()
    {
        AddField("mimeType");
        return this;
    }

    public MediaImageQueryBuilder AddFieldOriginalSource()
    {
        AddField("originalSource");
        return this;
    }

    public MediaImageQueryBuilder AddFieldPreview()
    {
        AddField("preview");
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