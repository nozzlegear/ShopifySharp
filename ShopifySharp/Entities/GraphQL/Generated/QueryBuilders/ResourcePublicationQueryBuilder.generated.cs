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

public class ResourcePublicationQueryBuilder() : GraphQueryBuilder<ResourcePublication>("resourcePublication")
{
    public ResourcePublicationQueryBuilder AddFieldChannel(Func<ChannelQueryBuilder, ChannelQueryBuilder> build)
    {
        AddField<Channel, ChannelQueryBuilder>("channel", build);
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldPublishable(Func<PublishableQueryBuilder, PublishableQueryBuilder> build)
    {
        AddField<IPublishable, PublishableQueryBuilder>("publishable", build);
        return this;
    }

    public ResourcePublicationQueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}