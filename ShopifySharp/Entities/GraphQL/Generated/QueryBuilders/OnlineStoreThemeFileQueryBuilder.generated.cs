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

public class OnlineStoreThemeFileQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFile>("onlineStoreThemeFile")
{
    public OnlineStoreThemeFileQueryBuilder AddUnionCaseBody(Func<OnlineStoreThemeFileBodyBase64QueryBuilder, OnlineStoreThemeFileBodyBase64QueryBuilder> build)
    {
        AddUnion<OnlineStoreThemeFileBodyBase64, OnlineStoreThemeFileBodyBase64QueryBuilder>("body", build);
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddUnionCaseBody(Func<OnlineStoreThemeFileBodyTextQueryBuilder, OnlineStoreThemeFileBodyTextQueryBuilder> build)
    {
        AddUnion<OnlineStoreThemeFileBodyText, OnlineStoreThemeFileBodyTextQueryBuilder>("body", build);
        return this;
    }

    public OnlineStoreThemeFileQueryBuilder AddUnionCaseBody(Func<OnlineStoreThemeFileBodyUrlQueryBuilder, OnlineStoreThemeFileBodyUrlQueryBuilder> build)
    {
        AddUnion<OnlineStoreThemeFileBodyUrl, OnlineStoreThemeFileBodyUrlQueryBuilder>("body", build);
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