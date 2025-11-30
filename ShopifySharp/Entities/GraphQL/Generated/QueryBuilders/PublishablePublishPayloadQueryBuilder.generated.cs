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

public class PublishablePublishPayloadQueryBuilder() : GraphQueryBuilder<PublishablePublishPayload>("publishablePublishPayload")
{
    public PublishablePublishPayloadQueryBuilder AddFieldPublishable(Func<PublishableQueryBuilder, PublishableQueryBuilder> build)
    {
        AddField<IPublishable, PublishableQueryBuilder>("publishable", build);
        return this;
    }

    public PublishablePublishPayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public PublishablePublishPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}