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

public class IOnlineStorePreviewableQueryBuilder() : GraphQueryBuilder<IOnlineStorePreviewable>("query iOnlineStorePreviewable")
{
    public IOnlineStorePreviewableQueryBuilder AddFieldOnlineStorePreviewUrl()
    {
        AddField("onlineStorePreviewUrl");
        return this;
    }
}