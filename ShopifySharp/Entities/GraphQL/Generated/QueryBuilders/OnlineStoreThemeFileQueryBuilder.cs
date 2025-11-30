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

public class OnlineStoreThemeFileQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFile>("query onlineStoreThemeFile")
{
    public OnlineStoreThemeFileQueryBuilder AddFieldBody()
    {
        AddField("body");
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddFieldChecksumMd5()
    {
        AddField("checksumMd5");
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddFieldContentType()
    {
        AddField("contentType");
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddFieldFilename()
    {
        AddField("filename");
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddFieldSize()
    {
        AddField("size");
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}