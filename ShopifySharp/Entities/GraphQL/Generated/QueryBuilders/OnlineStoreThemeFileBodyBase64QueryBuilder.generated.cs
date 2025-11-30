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

public class OnlineStoreThemeFileBodyBase64QueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFileBodyBase64>("onlineStoreThemeFileBodyBase64")
{
    public OnlineStoreThemeFileBodyBase64QueryBuilder AddFieldContentBase64()
    {
        AddField("contentBase64");
        return this;
    }
}