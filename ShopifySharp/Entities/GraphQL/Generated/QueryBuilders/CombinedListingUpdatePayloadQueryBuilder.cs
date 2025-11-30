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

public class CombinedListingUpdatePayloadQueryBuilder() : GraphQueryBuilder<CombinedListingUpdatePayload>("query combinedListingUpdatePayload")
{
    public CombinedListingUpdatePayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public CombinedListingUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}