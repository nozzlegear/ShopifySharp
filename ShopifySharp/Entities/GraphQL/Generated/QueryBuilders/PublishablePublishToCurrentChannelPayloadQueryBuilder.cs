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

public class PublishablePublishToCurrentChannelPayloadQueryBuilder() : GraphQueryBuilder<PublishablePublishToCurrentChannelPayload>("query publishablePublishToCurrentChannelPayload")
{
    public PublishablePublishToCurrentChannelPayloadQueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public PublishablePublishToCurrentChannelPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public PublishablePublishToCurrentChannelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}