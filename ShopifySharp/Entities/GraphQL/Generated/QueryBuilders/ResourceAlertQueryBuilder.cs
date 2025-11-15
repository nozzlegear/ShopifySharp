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

public class ResourceAlertQueryBuilder() : GraphQueryBuilder<ResourceAlert>("query resourceAlert")
{
    public ResourceAlertQueryBuilder AddFieldActions()
    {
        AddField("actions");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldContent()
    {
        AddField("content");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldDismissibleHandle()
    {
        AddField("dismissibleHandle");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldIcon()
    {
        AddField("icon");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldSeverity()
    {
        AddField("severity");
        return this;
    }

    public ResourceAlertQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}