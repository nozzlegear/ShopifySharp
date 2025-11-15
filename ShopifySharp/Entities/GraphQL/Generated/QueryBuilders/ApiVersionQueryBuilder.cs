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

public class ApiVersionQueryBuilder() : GraphQueryBuilder<ApiVersion>("query apiVersion")
{
    public ApiVersionQueryBuilder AddFieldDisplayName()
    {
        AddField("displayName");
        return this;
    }

    public ApiVersionQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public ApiVersionQueryBuilder AddFieldSupported()
    {
        AddField("supported");
        return this;
    }
}