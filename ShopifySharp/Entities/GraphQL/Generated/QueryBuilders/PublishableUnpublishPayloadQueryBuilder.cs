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

public class PublishableUnpublishPayloadQueryBuilder() : GraphQueryBuilder<PublishableUnpublishPayload>("query publishableUnpublishPayload")
{
    public PublishableUnpublishPayloadQueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public PublishableUnpublishPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public PublishableUnpublishPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}