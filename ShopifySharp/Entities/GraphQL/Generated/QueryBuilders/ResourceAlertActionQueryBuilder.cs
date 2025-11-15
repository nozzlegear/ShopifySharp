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

public class ResourceAlertActionQueryBuilder() : GraphQueryBuilder<ResourceAlertAction>("query resourceAlertAction")
{
    public ResourceAlertActionQueryBuilder AddFieldPrimary()
    {
        AddField("primary");
        return this;
    }

    public ResourceAlertActionQueryBuilder AddFieldShow()
    {
        AddField("show");
        return this;
    }

    public ResourceAlertActionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public ResourceAlertActionQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}