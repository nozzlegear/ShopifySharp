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

public class PublicationDeletePayloadQueryBuilder() : GraphQueryBuilder<PublicationDeletePayload>("query publicationDeletePayload")
{
    public PublicationDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public PublicationDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}