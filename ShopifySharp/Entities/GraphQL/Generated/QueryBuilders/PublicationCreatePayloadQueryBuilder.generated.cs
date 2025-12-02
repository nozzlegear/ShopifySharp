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

public class PublicationCreatePayloadQueryBuilder() : GraphQueryBuilder<PublicationCreatePayload>("publicationCreatePayload")
{
    public PublicationCreatePayloadQueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
        return this;
    }

    public PublicationCreatePayloadQueryBuilder AddFieldUserErrors(Func<PublicationUserErrorQueryBuilder, PublicationUserErrorQueryBuilder> build)
    {
        AddField<PublicationUserError, PublicationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}