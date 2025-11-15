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

public class IPublishableQueryBuilder() : GraphQueryBuilder<IPublishable>("query iPublishable")
{
    public IPublishableQueryBuilder AddFieldAvailablePublicationsCount()
    {
        AddField("availablePublicationsCount");
        return this;
    }

    [Obsolete("Use `resourcePublicationsCount` instead.")]
    public IPublishableQueryBuilder AddFieldPublicationCount()
    {
        AddField("publicationCount");
        return this;
    }

    [Obsolete("Use `publishedOnPublication` instead.")]
    public IPublishableQueryBuilder AddFieldPublishedOnChannel()
    {
        AddField("publishedOnChannel");
        return this;
    }

    [Obsolete("Use `publishedOnCurrentPublication` instead.")]
    public IPublishableQueryBuilder AddFieldPublishedOnCurrentChannel()
    {
        AddField("publishedOnCurrentChannel");
        return this;
    }

    public IPublishableQueryBuilder AddFieldPublishedOnCurrentPublication()
    {
        AddField("publishedOnCurrentPublication");
        return this;
    }

    public IPublishableQueryBuilder AddFieldPublishedOnPublication()
    {
        AddField("publishedOnPublication");
        return this;
    }

    public IPublishableQueryBuilder AddFieldResourcePublications()
    {
        AddField("resourcePublications");
        return this;
    }

    public IPublishableQueryBuilder AddFieldResourcePublicationsCount()
    {
        AddField("resourcePublicationsCount");
        return this;
    }

    public IPublishableQueryBuilder AddFieldResourcePublicationsV2()
    {
        AddField("resourcePublicationsV2");
        return this;
    }

    [Obsolete("Use `unpublishedPublications` instead.")]
    public IPublishableQueryBuilder AddFieldUnpublishedChannels()
    {
        AddField("unpublishedChannels");
        return this;
    }

    public IPublishableQueryBuilder AddFieldUnpublishedPublications()
    {
        AddField("unpublishedPublications");
        return this;
    }
}