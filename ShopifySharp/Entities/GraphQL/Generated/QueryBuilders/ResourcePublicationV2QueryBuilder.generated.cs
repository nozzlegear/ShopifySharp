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

public class ResourcePublicationV2QueryBuilder() : GraphQueryBuilder<ResourcePublicationV2>("resourcePublicationV2")
{
    public ResourcePublicationV2QueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public ResourcePublicationV2QueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
        return this;
    }

    public ResourcePublicationV2QueryBuilder AddFieldPublishable(Func<PublishableQueryBuilder, PublishableQueryBuilder> build)
    {
        AddField<IPublishable, PublishableQueryBuilder>("publishable", build);
        return this;
    }

    public ResourcePublicationV2QueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}