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

public class ResourcePublicationV2QueryBuilder() : GraphQueryBuilder<ResourcePublicationV2>("query resourcePublicationV2")
{
    public ResourcePublicationV2QueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public ResourcePublicationV2QueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public ResourcePublicationV2QueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public ResourcePublicationV2QueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}