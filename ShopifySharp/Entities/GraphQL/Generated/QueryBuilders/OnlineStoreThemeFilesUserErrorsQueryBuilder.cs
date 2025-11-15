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

public class OnlineStoreThemeFilesUserErrorsQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFilesUserErrors>("query onlineStoreThemeFilesUserErrors")
{
    public OnlineStoreThemeFilesUserErrorsQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public OnlineStoreThemeFilesUserErrorsQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public OnlineStoreThemeFilesUserErrorsQueryBuilder AddFieldFilename()
    {
        AddField("filename");
        return this;
    }

    public OnlineStoreThemeFilesUserErrorsQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}