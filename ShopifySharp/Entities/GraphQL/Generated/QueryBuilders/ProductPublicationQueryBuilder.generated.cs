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

public class ProductPublicationQueryBuilder() : GraphQueryBuilder<ProductPublication>("productPublication")
{
    public ProductPublicationQueryBuilder AddFieldChannel(Func<ChannelQueryBuilder, ChannelQueryBuilder> build)
    {
        AddField<Channel, ChannelQueryBuilder>("channel", build);
        return this;
    }

    public ProductPublicationQueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public ProductPublicationQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductPublicationQueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}