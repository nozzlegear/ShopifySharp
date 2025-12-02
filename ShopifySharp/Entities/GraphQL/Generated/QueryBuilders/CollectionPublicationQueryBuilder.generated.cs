#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CollectionPublicationQueryBuilder() : GraphQueryBuilder<CollectionPublication>("collectionPublication")
{
    public CollectionPublicationQueryBuilder AddFieldChannel(Func<ChannelQueryBuilder, ChannelQueryBuilder> build)
    {
        AddField<Channel, ChannelQueryBuilder>("channel", build);
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldCollection(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddField<Collection, CollectionQueryBuilder>("collection", build);
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
        return this;
    }

    public CollectionPublicationQueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}