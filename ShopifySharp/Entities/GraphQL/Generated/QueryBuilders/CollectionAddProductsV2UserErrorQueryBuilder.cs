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

public class CollectionAddProductsV2UserErrorQueryBuilder() : GraphQueryBuilder<CollectionAddProductsV2UserError>("query collectionAddProductsV2UserError")
{
    public CollectionAddProductsV2UserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CollectionAddProductsV2UserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CollectionAddProductsV2UserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}