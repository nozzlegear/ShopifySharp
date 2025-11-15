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

public class ProductPublicationQueryBuilder() : GraphQueryBuilder<ProductPublication>("query productPublication")
{
    public ProductPublicationQueryBuilder AddFieldChannel()
    {
        AddField("channel");
        return this;
    }

    public ProductPublicationQueryBuilder AddFieldIsPublished()
    {
        AddField("isPublished");
        return this;
    }

    public ProductPublicationQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductPublicationQueryBuilder AddFieldPublishDate()
    {
        AddField("publishDate");
        return this;
    }
}