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

public class AppUninstallAppUninstallErrorQueryBuilder() : GraphQueryBuilder<AppUninstallAppUninstallError>("query appUninstallAppUninstallError")
{
    public AppUninstallAppUninstallErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public AppUninstallAppUninstallErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public AppUninstallAppUninstallErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}