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

public class PublicationUpdatePayloadQueryBuilder() : GraphQueryBuilder<PublicationUpdatePayload>("query publicationUpdatePayload")
{
    public PublicationUpdatePayloadQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public PublicationUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}