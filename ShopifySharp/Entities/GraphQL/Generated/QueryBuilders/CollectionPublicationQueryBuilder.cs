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

public class CollectionPublicationQueryBuilder() : GraphQueryBuilder<CollectionPublication>("query collectionPublication")
{
    [Obsolete("Use `publication` instead.")]
    public CollectionPublicationQueryBuilder AddFieldChannel()
    {
        AddField("channel");
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldCollection()
    {
        AddField("collection");
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}