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

public class ShopifyFunctionQueryBuilder() : GraphQueryBuilder<ShopifyFunction>("query shopifyFunction")
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

    public ShopifyFunctionQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public ShopifyFunctionQueryBuilder AddFieldAppBridge()
    {
        AddField("appBridge");
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