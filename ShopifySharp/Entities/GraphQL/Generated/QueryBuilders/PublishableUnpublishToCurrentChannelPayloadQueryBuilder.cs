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

public class PublishableUnpublishToCurrentChannelPayloadQueryBuilder() : GraphQueryBuilder<PublishableUnpublishToCurrentChannelPayload>("query publishableUnpublishToCurrentChannelPayload")
{
    public PublishableUnpublishToCurrentChannelPayloadQueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public PublishableUnpublishToCurrentChannelPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public PublishableUnpublishToCurrentChannelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}