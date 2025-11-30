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

public class ShopAlertActionQueryBuilder() : GraphQueryBuilder<ShopAlertAction>("query shopAlertAction")
{
    public ShopAlertActionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ShopAlertActionQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}