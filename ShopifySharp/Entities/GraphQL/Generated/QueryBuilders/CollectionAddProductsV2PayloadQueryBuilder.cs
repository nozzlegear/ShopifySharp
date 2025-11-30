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

public class CollectionAddProductsV2PayloadQueryBuilder() : GraphQueryBuilder<CollectionAddProductsV2Payload>("query collectionAddProductsV2Payload")
{
    public CollectionAddProductsV2PayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public CollectionAddProductsV2PayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}