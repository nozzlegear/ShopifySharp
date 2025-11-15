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

public class OnlineStoreThemeQueryBuilder() : GraphQueryBuilder<OnlineStoreTheme>("query onlineStoreTheme")
{
    public OnlineStoreThemeQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldFiles()
    {
        AddField("files");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldPrefix()
    {
        AddField("prefix");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldProcessing()
    {
        AddField("processing");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldProcessingFailed()
    {
        AddField("processingFailed");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldRole()
    {
        AddField("role");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldThemeStoreId()
    {
        AddField("themeStoreId");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldTranslations()
    {
        AddField("translations");
        return this;
    }

    public OnlineStoreThemeQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}