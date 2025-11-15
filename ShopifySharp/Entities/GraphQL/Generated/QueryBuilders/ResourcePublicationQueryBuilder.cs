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

public class ResourcePublicationQueryBuilder() : GraphQueryBuilder<ResourcePublication>("query resourcePublication")
{
    [Obsolete("Use `publication` instead.")]
    public ResourcePublicationQueryBuilder AddFieldChannel()
    {
        AddField("channel");
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}