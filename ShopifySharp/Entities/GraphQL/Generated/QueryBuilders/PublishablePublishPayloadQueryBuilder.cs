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

public class PublishablePublishPayloadQueryBuilder() : GraphQueryBuilder<PublishablePublishPayload>("query publishablePublishPayload")
{
    public PublishablePublishPayloadQueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public PublishablePublishPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public PublishablePublishPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}