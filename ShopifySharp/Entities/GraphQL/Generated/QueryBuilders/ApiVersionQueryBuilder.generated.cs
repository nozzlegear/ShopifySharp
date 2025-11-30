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

public class ApiVersionQueryBuilder() : GraphQueryBuilder<ApiVersion>("apiVersion")
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