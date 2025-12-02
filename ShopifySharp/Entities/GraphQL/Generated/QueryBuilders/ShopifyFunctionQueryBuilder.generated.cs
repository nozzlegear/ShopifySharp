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

public class ShopifyFunctionQueryBuilder() : GraphQueryBuilder<ShopifyFunction>("shopifyFunction")
{
    public ShopifyFunctionQueryBuilder AddFieldApiType()
    {
        AddField("apiType");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldApiVersion()
    {
        AddField("apiVersion");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldAppBridge(Func<FunctionsAppBridgeQueryBuilder, FunctionsAppBridgeQueryBuilder> build)
    {
        AddField<FunctionsAppBridge, FunctionsAppBridgeQueryBuilder>("appBridge", build);
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldAppKey()
    {
        AddField("appKey");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldInputQuery()
    {
        AddField("inputQuery");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldUseCreationUi()
    {
        AddField("useCreationUi");
        return this;
    }
}