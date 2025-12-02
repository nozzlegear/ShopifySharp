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

public class PublishableQueryBuilder() : GraphQueryBuilder<IPublishable>("publishable")
{
    public PublishableQueryBuilder AddFieldAvailablePublicationsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("availablePublicationsCount", build);
        return this;
    }

    [Obsolete("Use `resourcePublicationsCount` instead.")]
    public PublishableQueryBuilder AddFieldPublicationCount()
    {
        AddField("publicationCount");
        return this;
    }

    [Obsolete("Use `publishedOnPublication` instead.")]
    public PublishableQueryBuilder AddFieldPublishedOnChannel()
    {
        AddField("publishedOnChannel");
        return this;
    }

    [Obsolete("Use `publishedOnCurrentPublication` instead.")]
    public PublishableQueryBuilder AddFieldPublishedOnCurrentChannel()
    {
        AddField("publishedOnCurrentChannel");
        return this;
    }

    public PublishableQueryBuilder AddFieldPublishedOnCurrentPublication()
    {
        AddField("publishedOnCurrentPublication");
        return this;
    }

    public PublishableQueryBuilder AddFieldPublishedOnPublication()
    {
        AddField("publishedOnPublication");
        return this;
    }

    public PublishableQueryBuilder AddFieldResourcePublications(Func<ResourcePublicationConnectionQueryBuilder, ResourcePublicationConnectionQueryBuilder> build)
    {
        AddField<ResourcePublicationConnection, ResourcePublicationConnectionQueryBuilder>("resourcePublications", build);
        return this;
    }

    public PublishableQueryBuilder AddFieldResourcePublicationsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("resourcePublicationsCount", build);
        return this;
    }

    public PublishableQueryBuilder AddFieldResourcePublicationsV2(Func<ResourcePublicationV2ConnectionQueryBuilder, ResourcePublicationV2ConnectionQueryBuilder> build)
    {
        AddField<ResourcePublicationV2Connection, ResourcePublicationV2ConnectionQueryBuilder>("resourcePublicationsV2", build);
        return this;
    }

    public PublishableQueryBuilder AddFieldUnpublishedChannels(Func<ChannelConnectionQueryBuilder, ChannelConnectionQueryBuilder> build)
    {
        AddField<ChannelConnection, ChannelConnectionQueryBuilder>("unpublishedChannels", build);
        return this;
    }

    public PublishableQueryBuilder AddFieldUnpublishedPublications(Func<PublicationConnectionQueryBuilder, PublicationConnectionQueryBuilder> build)
    {
        AddField<PublicationConnection, PublicationConnectionQueryBuilder>("unpublishedPublications", build);
        return this;
    }
}