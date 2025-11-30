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

public class PageUpdatePayloadQueryBuilder() : GraphQueryBuilder<PageUpdatePayload>("query pageUpdatePayload")
{
    public PageUpdatePayloadQueryBuilder AddFieldPage()
    {
        AddField("page");
        return this;
    }

    public PageUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}