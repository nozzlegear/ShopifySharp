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

public class OnlineStoreThemeFileOperationResultQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFileOperationResult>("onlineStoreThemeFileOperationResult")
{
    public OnlineStoreThemeFileOperationResultQueryBuilder AddFieldChecksumMd5()
    {
        AddField("checksumMd5");
        return this;
    }

    public OnlineStoreThemeFileOperationResultQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public OnlineStoreThemeFileOperationResultQueryBuilder AddFieldFilename()
    {
        AddField("filename");
        return this;
    }

    public OnlineStoreThemeFileOperationResultQueryBuilder AddFieldSize()
    {
        AddField("size");
        return this;
    }

    public OnlineStoreThemeFileOperationResultQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}