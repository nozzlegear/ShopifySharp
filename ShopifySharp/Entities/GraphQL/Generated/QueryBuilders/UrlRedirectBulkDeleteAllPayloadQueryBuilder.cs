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

public class UrlRedirectBulkDeleteAllPayloadQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteAllPayload>("query urlRedirectBulkDeleteAllPayload")
{
    public UrlRedirectBulkDeleteAllPayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public UrlRedirectBulkDeleteAllPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}